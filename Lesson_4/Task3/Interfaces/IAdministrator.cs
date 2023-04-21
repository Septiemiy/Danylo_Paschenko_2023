using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IAdministrator
    {
        void WriteToFile(string filename);
        void SaveToFile(string filename);
        void GetDataFromFile(string filename);
    }
}
