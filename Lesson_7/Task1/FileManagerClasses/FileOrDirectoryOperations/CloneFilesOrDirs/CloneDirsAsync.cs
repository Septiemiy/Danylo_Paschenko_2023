using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class CloneDirsAsync
    {
        async public static Task CloneDirAsync(string dirPath)
        {
            if (CheckDir(dirPath) == false) return;

            if (CreateCloneDir(dirPath) == false) return;

            CopyDirsAndFilesToClonedDir(dirPath);

            UserInterface.SucceedMessage();
        }

        private static void CopyDirsAndFilesToClonedDir(string dirPath)
        {
            CopyFilesToClonedDir(dirPath);
            CopyDirsToClonedDir(dirPath);
        }

        private static void CopyDirsToClonedDir(string dirPath)
        {
            try
            {
                foreach (var subDir in GetDirectoryInfo(dirPath).GetDirectories())
                {
                    string subDirPath = Path.Combine(CreateCloneDirName(dirPath), subDir.Name);
                    CreateCloneDir(subDirPath);
                    CopyDirsAndFilesToClonedDir(subDirPath);
                }
            }
            catch
            {

            }
        }

        private static void CopyFilesToClonedDir(string dirPath)
        {
            foreach (var file in GetDirectoryInfo(dirPath).GetFiles())
            {
                string filePath = Path.Combine(CreateCloneDirName(dirPath), file.Name);
                file.CopyTo(filePath);
            }
        }

        private static DirectoryInfo GetDirectoryInfo(string dirPath)
        {
            var dirInfo = new DirectoryInfo(dirPath);
            return dirInfo;
        }

        private static string CreateCloneDirName(string dirPath)
        {
            var copyDirName = GetDirectoryInfo(dirPath).FullName + "-copy";

            return copyDirName;
        }

        private static bool CreateCloneDir(string dirPath)
        {
            if (!Directory.Exists(CreateCloneDirName(dirPath)))
            {
                Directory.CreateDirectory(CreateCloneDirName(dirPath));
                return true;
            }
            else
            {
                Console.WriteLine("\n---Error: This directory already has a copy---");
                return false;
            }
        }

        private static bool CheckDir(string dirPath)
        {
            if (!Directory.Exists(dirPath))
            {
                Console.WriteLine("\n---Error: Directory with this name don't exists---");
                return false;
            }
            return true;
        }
    }
}
