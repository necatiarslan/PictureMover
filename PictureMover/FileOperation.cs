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
        public enum DestinationFolderStructureType
        {
            Year_MonthName_Day,
            Year_MonthName,
            Year_Month_Day,
            Year_Month
        }

        public static DateTime? GetDateTaken(string filePath)
        {
            string fileExtension = Path.GetExtension(filePath).ToLower();

            if (IsImageFile(fileExtension))
            {
                return ReadDateFromImage(filePath);
            }
            else if (IsVideoFile(fileExtension))
            {
                return null;
                //return ReadDateFromVideo(filePath);
            }
            else
            {
                return null;
            }
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

        public static string CopyFileToDestination(string rootFolder, string subFolder, string filePath)
        {
            string destinationDirectory = Path.Combine(rootFolder, subFolder);
            string destinationFilePath = Path.Combine(destinationDirectory, Path.GetFileName(filePath));

            // Create the subfolders if they don't exist
            Directory.CreateDirectory(destinationDirectory);

            // Check if a file with the same name already exists in the destination folder
            if (File.Exists(destinationFilePath))
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
                string fileExtension = Path.GetExtension(filePath);

                // Generate 3 random characters to append to the file name
                string randomChars = GenerateRandomChars(3);

                // Append the random characters and the file extension to the file name
                string newFileName = $"{fileNameWithoutExtension}_{randomChars}{fileExtension}";

                destinationFilePath = Path.Combine(destinationDirectory, newFileName);
            }

            // Copy the file to the destination
            File.Copy(filePath, destinationFilePath);

            return destinationFilePath;
        }

        private static string GenerateRandomChars(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static bool IsFileExistsInDestinationWithExtension(string rootFolder, string subFolder, string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            string destinationDirectory = Path.Combine(rootFolder, subFolder);

            if (!Directory.Exists(destinationDirectory))
            {
                return false;
            }

                // Get all files with the same extension in the destination folder and subfolders
            string[] destinationFiles = Directory.GetFiles(destinationDirectory, "*" + extension, SearchOption.AllDirectories);

            string sourceHash = CalculateFileHash(filePath);

            foreach (string destinationFile in destinationFiles)
            {
                string destinationHash = CalculateFileHash(destinationFile);

                if (sourceHash == destinationHash)
                {
                    // File with the same extension and content exists in destination
                    return true;
                }
            }

            // No file with the same extension and content is found in the destination
            return false;
        }

        private static string CalculateFileHash(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hashBytes = md5.ComputeHash(stream);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
            }
        }

        public static bool IsThereAFileWithTheSameNameOnDestination(string rootFolder, string subFolder, string filePath)
        {
            string fullPath = Path.Combine(rootFolder, subFolder, Path.GetFileName(filePath));

            if (File.Exists(fullPath))
            {
                return true;
            }

            return false;
        }

        public static bool IsImageFile(string fileExtension)
        {
            return new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tif", ".tiff" }.Contains(fileExtension);
        }

        public static bool IsMatch(string fileName, string pattern)
        {
            // Check if the file name matches the pattern using wildcards
            string patternRegex = "^" + Regex.Escape(pattern).Replace("\\*", ".*").Replace("\\?", ".") + "$";
            return Regex.IsMatch(fileName, patternRegex, RegexOptions.IgnoreCase);
        }

        public static bool IsVideoFile(string fileExtension)
        {
            return new[] { ".mp4", ".avi", ".mkv", ".mov", ".wmv", ".flv", ".m4v", ".3gp", ".mpg", ".webm" }.Contains(fileExtension);
        }

        public static DateTime ReadDateFromImage(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (Image image = Image.FromStream(fs, false, false))
                {
                    PropertyItem propertyItem = image.GetPropertyItem(36867); // PropertyId for Date Taken

                    string dateTaken = Encoding.ASCII.GetString(propertyItem.Value).Trim();
                    return DateTime.ParseExact(dateTaken, "yyyy:MM:dd HH:mm:ss", null);
                }
            }
            catch
            {
                // If Date Taken metadata is not available, use file creation time
                return File.GetCreationTime(filePath);
            }
        }

        public static DateTime ReadDateFromVideo(string filePath)
        {
            // For video files, use file creation time as there's no direct way to extract date taken
            return File.GetCreationTime(filePath);
        }
    }
}
