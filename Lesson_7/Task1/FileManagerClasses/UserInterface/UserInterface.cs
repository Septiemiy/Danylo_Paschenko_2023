using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class UserInterface
    {
        public static void UserMenu()
        {
            Console.WriteLine(
                "\nMove to CD across the system (1)" +
                "\nShow files or dirs content (2)" +
                "\nMove files or dirs (3)" +
                "\nRemove files or dirs (4)" +
                "\nClone files or dirs (5)" +
                "\nGet files or dirs information (6)" +
                "\nExit (7)");
        }

        public static string GetUserChoice() 
        {
            Console.Write("\nEntire your choice: ");
            string userChoice = Console.ReadLine();
            return userChoice;
        }

        public static void ChoiceError()
        {
            Console.WriteLine("\n---Error: Your choice invalid---");
        }

        public static void CurrentDirectoryCheck() 
        {
            Console.WriteLine($"\nYour current directory: {Directory.GetCurrentDirectory()}");
        }

        public static void SucceedMessage() 
        {
            Console.WriteLine("\n---Succeeded---");
        }

        public static void MoveToCDInterface()
        {
            Console.WriteLine(
                "\nGo to a new directory (1)" +
                "\nGo back one directory (2)" +
                "\nCancel (3)");
        }

        private static string GetDirOrFilePath() 
        {
            string path = Console.ReadLine();
            return path;
        }

        public static string GetDirectoryPath() 
        {
            Console.Write("\nEntire directory path or name if directory in the current context: ");
            return GetDirOrFilePath();
        }

        public static string GetFilePath()
        {
            Console.Write("\nEntire file path or name if file in the current context: ");
            return GetDirOrFilePath();
        }

        private static string GetDirectoryName()
        {
            Console.Write("\nEntire directory name: ");
            return GetDirOrFilePath();
        }

        private static string GetFileName()
        {
            Console.Write("\nEntire file name: ");
            return GetDirOrFilePath();
        }

        private static string GetNewPath()
        {
            Console.Write("\nEntire new path: ");
            return GetDirOrFilePath();
        }

        public static void ShowContentInterface()
        {
            Console.WriteLine(
                "\nShow directories (1)" +
                "\nShow files (2)" +
                "\nShow all (3)" +
                "\nCancel (4)");
        }

        public static void OpenDirRequest()
        {
            while (true)
            {
                Console.Write("\nOpen directory? (y/n): ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "y":
                        OpenDirs.OpenDir(GetDirectoryName());
                        break;
                    case "n":
                        break;
                    default:
                        ChoiceError();
                        continue;
                }
                break;
            }
        }

        public static void OpenFileRequest()
        {
            while (true)
            {
                Console.Write("\nRead file? (y/n): ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "y":
                        ReadFiles.ReadFile(GetFileName());
                        break;
                    case "n":
                        break;
                    default:
                        ChoiceError();
                        continue;
                }
                break;
            }
        }

        public static void OpenAllRequest()
        {
            while (true)
            {
                Console.Write("\nOpen directory or read file? (d/f)\nCancel - (c): ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "d":
                        OpenDirs.OpenDir(GetDirectoryName());
                        break;
                    case "f":
                        ReadFiles.ReadFile(GetFileName());
                        break;
                    case "c":
                        break;
                    default:
                        ChoiceError();
                        continue;
                }
                break;
            }
        }

        async public static Task MoveFileOrDirRequestAsync()
        {
            while (true)
            {
                Console.Write("\nMove dir or file? (d/f)\nCancel - (c): ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "d":
                        await MoveDirsAsync.MoveDirAsync(GetDirectoryPath(), GetNewPath());
                        continue;
                    case "f":
                        await MoveFilesAsync.MoveFileAsync(GetFilePath(), GetNewPath());
                        continue;                
                    case "c":
                        break;
                    default:
                        ChoiceError();
                        continue;
                }
                break;
            }
        }

        async public static Task RemoveFileOrDirRequestAsync()
        {
            while (true)
            {
                Console.Write("\nRemove dir or file? (d/f)\nCancel - (c): ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "d":
                        await RemoveDirsAsync.RemoveDirAsync(GetDirectoryPath());
                        continue;
                    case "f":
                        await RemoveFilesAsync.RemoveFileAsync(GetFilePath());
                        continue;
                    case "c":
                        break;
                    default:
                        ChoiceError();
                        continue;
                }
                break;
            }
        }

        async public static Task CloneFileOrDirRequestAsync()
        {
            while (true)
            {
                Console.Write("\nClone dir or file? (d/f)\nCancel - (c): ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "d":
                        await CloneDirsAsync.CloneDirAsync(GetDirectoryPath());
                        continue;
                    case "f":
                        await CloneFilesAsync.CloneFileAsync(GetFilePath());
                        continue;
                    case "c":
                        break;
                    default:
                        ChoiceError();
                        continue;
                }
                break;
            }
        }

        public static void GetFileOrDirInfoRequest()
        {
            while (true)
            {
                Console.Write("\nGet information about dir or file? (d/f)\nCancel - (c): ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "d":
                        GetDirInfo.OutputInfo(GetDirectoryPath());
                        break;
                    case "f":
                        GetFileInfo.OutputInfo(GetFilePath());
                        break;
                    case "c":
                        break;
                    default:
                        ChoiceError();
                        continue;
                }
                break;
            }
        }
    }
}
