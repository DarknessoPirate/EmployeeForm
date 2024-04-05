using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

[Serializable]
public class Pracownik
{
    public string name { get; set; }
    public string surname { get; set; }
    public double salary { get; set; }
    public DateTime dateOfBirth { get; set; }
    public string position { get; set; }
    public string contractType { get; set; }

    public Pracownik()
    {

    }
    public Pracownik(string[] parameters)
    {
        name = parameters[0];
        surname = parameters[1];
        salary =Double.Parse(parameters[2]);
        dateOfBirth =DateTime.Parse(parameters[3]);
        position = parameters[4];
        contractType = parameters[5];
    }
    public Pracownik(string imie, string nazwisko, double placa, DateTime data, string stanowisko, string umowa)
    {
        name = imie;
        surname = nazwisko;
        salary = placa;
        dateOfBirth = data;
        position = stanowisko;
        contractType = umowa;
    }

}

