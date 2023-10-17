using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PictureMover
{
    public enum SourceFileType
    {
        Unknown,
        Picture,
        Video
    }

    internal class SourceFile
    {
        private string fileHash;
        public string FilePath { get; set; }
        public FileInfo FileInfo { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string Directory { get; set; }
        public DateTime LastWriteTime { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime FileTime
        {
            get
            {
                if(this.LastWriteTime < this.CreationTime)
                {
                    return this.LastWriteTime;
                }
                else
                {
                    return this.CreationTime;
                }
            }
        }
        public string DestinationFolder { get; set; }
        public bool IsFileCopied { get; set; }
        public SourceFileType SourceFileType { get; set; }
        public string FileNameWithoutExtension { get; set; }
        public long Lenght { get; set; }
        public string FileHash
        {
            get
            {
                if(this.fileHash == null)
                {
                    this.fileHash = SourceFile.CalculateFileHash(this.FilePath);
                }
                return this.fileHash;
            }
        }
        public bool ExistsInDestination { get; set; }

        public SourceFile(string filePath) {
            this.FilePath = filePath;
            FileInfo fileInfo = new FileInfo(filePath);
            this.FileInfo = fileInfo;
            this.FileName = fileInfo.Name;
            this.Extension = fileInfo.Extension;
            this.Directory = fileInfo.DirectoryName;
            this.LastWriteTime = fileInfo.LastWriteTime;
            this.CreationTime = fileInfo.CreationTime;
            this.Lenght = fileInfo.Length;
            this.FileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);

            if (SourceFile.IsImageFile(this.Extension))
            {
                this.SourceFileType = SourceFileType.Picture;
            }
            else if (SourceFile.IsVideoFile(this.Extension))
            {
                this.SourceFileType= SourceFileType.Video;
            }
            else
            {
                this.SourceFileType = SourceFileType.Unknown;
            }
        }

        public static string CalculateFileHash(string filePath)
        {
            //using (var md5 = MD5.Create())
            //{
            //    using (var stream = File.OpenRead(filePath))
            //    {
            //        byte[] hashBytes = md5.ComputeHash(stream);
            //        return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            //    }
            //}
            using (SHA256 sha256 = SHA256.Create())
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[8192]; // 8KB buffer for reading the file in chunks
                    int bytesRead;

                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        sha256.TransformBlock(buffer, 0, bytesRead, null, 0);
                        //read only first 8KB
                        break;
                    }

                    sha256.TransformFinalBlock(buffer, 0, 0);

                    byte[] hashBytes = sha256.Hash;
                    string hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

                    return hash;
                }
            }
        }

        public static bool IsImageFile(string fileExtension)
        {
            return new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tif", ".tiff" }.Contains(fileExtension);
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
    }
}
