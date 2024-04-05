using Pracownicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Formularz
{
    internal class LoadState : ILoadFromTxtFile, ILoadFromXMLFile
    {
        public void LoadEmployeesFromTxtFile(ref IEnumerable<Pracownik> pracownicy, string path)
        {
            List<Pracownik> tempList = new List<Pracownik>();
            foreach (string line in File.ReadLines(path))
            {
                Pracownik tempPracownik = new Pracownik(line.Split(','));
                tempList.Add(tempPracownik);
            }
            pracownicy = tempList;
        }
        public void LoadEmployeesFromXMLFile(ref IEnumerable<Pracownik> pracownicy, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
            using (TextWriter writer = new StreamWriter("pracownicy.xml"))
            {
                serializer.Serialize(writer, pracownicy);
            }
        }
    }
}
