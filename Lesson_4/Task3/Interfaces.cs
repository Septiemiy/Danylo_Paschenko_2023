using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public interface IUser
    {
        string ReadFromFile(string filename);
        void DownloadFile(string filename);
        void CopyFile(string filename);
        void CheckFile(string filename);
    }

    public interface IAdministrator
    {
        void WriteToFile(string filename);
        void SaveToFile(string filename);
        void GetDataFromFile(string filename);
    }

    public interface IOwner
    {
        void DeleteFile(string filename);
    }

    public interface IWorkWithUsers
    {
        Guid CheckRole(Guid role);
        Guid CheckUser(Guid user);
    }
}