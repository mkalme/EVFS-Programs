using System;
using System.IO;
using EncryptedVirtualFileSystem;

namespace FileConverter {
    class EvfsConverter {
        public static VDirectory ConvertDirectory(string path) {
            VDirectory directory = new VDirectory(Path.GetFileName(path));

            directory.CreationDate = Directory.GetCreationTime(path);

            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            foreach (string dir in directories) {
                directory.AppendChild(ConvertDirectory(dir));
            }
            foreach (string file in files) {
                directory.AppendChild(ConvertFile(file));
            }

            return directory;
        }
        public static VFile ConvertFile(string path) {
            VFile file = new VFile(Path.GetFileName(path));

            file.CreationDate = File.GetCreationTime(path);
            file.LastModified = File.GetLastWriteTime(path);
            file.Bytes = File.ReadAllBytes(path);

            return file;
        }
    }
}
