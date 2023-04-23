using Task1;

while(true)
{
    UserInterface.UserMenu();
    var userChoice = UserInterface.GetUserChoice();

    switch(userChoice)
    {
        case "1":
            while (true)
            {
                UserInterface.MoveToCDInterface();
                var userChoiceMoveToCD = UserInterface.GetUserChoice();

                UserInterface.CurrentDirectoryCheck();

                switch (userChoiceMoveToCD)
                {
                    case "1":
                        MoveToCD.СheckDir(UserInterface.GetDirectoryPath());
                        UserInterface.CurrentDirectoryCheck();
                        break;
                    case "2":
                        MoveToCD.GoBackDirectory();
                        UserInterface.CurrentDirectoryCheck();
                        break;
                    case "3":
                        break;
                    default:
                        UserInterface.ChoiceError();
                        continue;
                }
                break;
            }
            continue;
        case "2":
            while (true)
            {
                UserInterface.CurrentDirectoryCheck();

                UserInterface.ShowContentInterface();
                var userChoiceShowContent = UserInterface.GetUserChoice();

                var showDirs = new ShowDirsClass();
                var showFiles = new ShowFilesClass();

                switch (userChoiceShowContent)
                {
                    case "1":
                        showDirs.ShowDirs();
                        UserInterface.OpenDirRequest();
                        continue;
                    case "2":
                        showFiles.ShowFiles();
                        UserInterface.OpenFileRequest();
                        continue;
                    case "3":
                        showDirs.ShowDirs();
                        showFiles.ShowFiles();
                        UserInterface.OpenAllRequest();
                        continue;
                    case "4":
                        break;
                    default:
                        UserInterface.ChoiceError();
                        continue;
                }
                break;
            }
            continue;
        case "3":
            while (true)
            {
                UserInterface.CurrentDirectoryCheck();

                UserInterface.MoveFileOrDirRequest();

                break;
            }
            continue;
        case "4":
            while (true)
            {
                UserInterface.CurrentDirectoryCheck();

                UserInterface.RemoveFileOrDirRequest();

                break;
            }
            continue;
        case "5":
            while (true)
            {
                UserInterface.CurrentDirectoryCheck();

                UserInterface.CloneFileOrDirRequest();

                break;
            }
            continue;
        case "6":
            while (true)
            {
                UserInterface.CurrentDirectoryCheck();

                UserInterface.GetFileOrDirInfoRequest();

                break;
            }
            continue;
        case "7":
            break;
        default:
            UserInterface.ChoiceError();
            continue;
    }
    break;
}