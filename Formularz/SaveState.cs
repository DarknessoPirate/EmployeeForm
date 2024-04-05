using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pracownicy
{
    public class SaveState: ISaveToTxtFile, ISaveToXMLFile
    {
        public void SaveEmployeesToTxtFile(IEnumerable<Pracownik> pracownicy, string path)
        {   
            using(StreamWriter writer = new StreamWriter(path))
            {
                foreach (var pracownik in pracownicy)
                {
                    writer.WriteLine($"{pracownik.name},{pracownik.surname}, {pracownik.dateOfBirth.ToShortDateString()}, {pracownik.salary}, {pracownik.position}, {pracownik.contractType}");
                }
            }
        }

        public void SaveEmployeesToXMLFile(IEnumerable<Pracownik> pracownicy, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(IEnumerable<Pracownik>));
            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, pracownicy);
            }
        }
    }
}
