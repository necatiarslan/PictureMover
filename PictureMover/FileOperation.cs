using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PictureMover
{
    internal class FileOperation
    {
        public static List<SourceFile> DestinationFileList = new List<SourceFile>();
        public enum DestinationFolderStructureType
        {
            Year_MonthName_Day,
            Year_MonthName,
            Year_Month_Day,
            Year_Month
        }

        public static List<string> GetAllFilePaths(string rootFolder, List<string> filesToInclude, List<string> filesToExclude)
        {
            List<string> filePaths = new List<string>();

            DirectoryInfo directory = new DirectoryInfo(rootFolder);

            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo file in files)
            {
                string fileName = Path.GetFileName(file.FullName);

                // Check if the file matches any of the patterns in "filesToInclude" and does not match any in "filesToExclude"
                if ((filesToInclude.Count == 0 || filesToInclude.Any(pattern => IsMatch(fileName, pattern))) &&
                    (filesToExclude.Count == 0 || !filesToExclude.Any(pattern => IsMatch(fileName, pattern))))
                {
                    filePaths.Add(file.FullName);
                }
            }

            DirectoryInfo[] subDirectories = directory.GetDirectories();
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                List<string> subDirectoryFilePaths = GetAllFilePaths(subDirectory.FullName, filesToInclude, filesToExclude);
                filePaths.AddRange(subDirectoryFilePaths);
            }

            return filePaths;
        }

        public static string GetDestinationFolderStructure(DateTime date, DestinationFolderStructureType type)
        {
            string result = "";

            if (type == DestinationFolderStructureType.Year_MonthName_Day)
            {

                result = date.Year.ToString() + "\\" + date.ToString("MM") + "-" + date.ToString("MMMM") + "\\" + date.ToString("dd");
            }
            else if (type == DestinationFolderStructureType.Year_MonthName)
            {
                result = date.Year.ToString() + "\\" + date.ToString("MM") + "-" + date.ToString("MMMM");
            }

            else if(type == DestinationFolderStructureType.Year_Month_Day) {

                result = date.Year.ToString() + "\\" + date.ToString("MM") + "\\" + date.ToString("dd");
            }
            else if(type==DestinationFolderStructureType.Year_Month)
            {
                result = date.Year.ToString() + "\\" + date.ToString("MM");
            }

            return result;
        }

        public static string CopyFileToDestination(string rootFolder, string subFolder, SourceFile sourceFile)
        {
            string destinationDirectory = Path.Combine(rootFolder, subFolder);
            string destinationFilePath = Path.Combine(destinationDirectory, sourceFile.FileName);

            // Create the subfolders if they don't exist
            Directory.CreateDirectory(destinationDirectory);

            // Check if a file with the same name already exists in the destination folder
            if (File.Exists(destinationFilePath))
            {
                string fileNameWithoutExtension = sourceFile.FileNameWithoutExtension;
                string fileExtension = sourceFile.Extension;

                // Generate 3 random characters to append to the file name
                string randomChars = GenerateRandomChars(3);

                // Append the random characters and the file extension to the file name
                string newFileName = $"{fileNameWithoutExtension}_{randomChars}{fileExtension}";

                destinationFilePath = Path.Combine(destinationDirectory, newFileName);
            }

            // Copy the file to the destination
            File.Copy(sourceFile.FilePath, destinationFilePath);

            return destinationFilePath;
        }

        private static string GenerateRandomChars(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static bool IsFileExistsInDestination(string rootFolder, string subFolder, SourceFile sourceFile)
        {
            string extension = sourceFile.Extension;

            string destinationDirectory = Path.Combine(rootFolder, subFolder);

            if (!Directory.Exists(destinationDirectory))
            {
                sourceFile.ExistsInDestination = false;
                return false;
            }

            if(File.Exists(Path.Combine(destinationDirectory, sourceFile.FileName)))
            {
                sourceFile.ExistsInDestination = true;
                return true;
            }

            // Get all files with the same extension in the destination folder and subfolders
            string[] destinationFiles = Directory.GetFiles(destinationDirectory, "*" + extension, SearchOption.AllDirectories);
            
            foreach (string destinationFile in destinationFiles)
            {
                if (!FileOperation.DestinationFileList.Any(file => file.FilePath == destinationFile))
                {
                    FileOperation.DestinationFileList.Add(new SourceFile(destinationFile));
                }
            }

            foreach (SourceFile destinationFile in FileOperation.DestinationFileList)
            {
                if (destinationFile.Lenght == sourceFile.Lenght)
                {
                    sourceFile.ExistsInDestination = true;
                    return true;
                }
            }

            foreach (SourceFile destinationFile in FileOperation.DestinationFileList)
            {
                if (sourceFile.FileHash == destinationFile.FileHash)
                {
                    sourceFile.ExistsInDestination = true;
                    return true;
                }
            }

            sourceFile.ExistsInDestination = false;
            return false;
        }

        public static bool IsMatch(string fileName, string pattern)
        {
            // Check if the file name matches the pattern using wildcards
            string patternRegex = "^" + Regex.Escape(pattern).Replace("\\*", ".*").Replace("\\?", ".") + "$";
            return Regex.IsMatch(fileName, patternRegex, RegexOptions.IgnoreCase);
        }
    }
}
