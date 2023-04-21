using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IUser
    {
        string ReadFromFile(string filename);
        void DownloadFile(string filename);
        void CopyFile(string filename);
        void CheckFile(string filename);
    }
}
