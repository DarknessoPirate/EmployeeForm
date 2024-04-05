using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    internal interface ISaveToTxtFile
    {
        public void SaveEmployeesToTxtFile(IEnumerable<Pracownik> pracownicy, string path);
    }

    internal interface ISaveToXMLFile
    {
        public void SaveEmployeesToTxtFile(IEnumerable<Pracownik> pracownicy, string path);
    }

    internal interface ILoadFromTxtFile
    {
        public void LoadEmployeesFromTxtFile(ref IEnumerable<Pracownik> pracownicy, string path);
    }

    internal interface ILoadFromXMLFile
    {
        public void LoadEmployeesFromXMLFile(ref IEnumerable<Pracownik> pracownicy, string path);
    }
}
