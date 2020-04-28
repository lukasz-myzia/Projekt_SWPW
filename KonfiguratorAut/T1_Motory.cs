using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonfiguratorAut
{
    class T1_Motory
    {
        public double Pojemnosc { get; protected set; }
        public int Fotel { get; protected set; }
        public string Opis { get; protected set; }

        public T1_Motory(double pojemnosc, int fotel = 2, string opis = "Mały skuter")
        {
            this.Pojemnosc = pojemnosc;
            this.Fotel = fotel;
            this.Opis = opis;
        }

        public static void Parametry()
        {
            Console.Write("Podaj pojemność z zakresu 50-125: ");
            double pojemnosc = double.Parse(Console.ReadLine());
            T1_Motory egzemplarz = new T1_Motory(pojemnosc);
            Console.WriteLine("---------------------");
            Console.WriteLine("{0} o pojemności {1} cm3 i fotelu {2} osobowym będzie Pana kosztował {3} PLN", egzemplarz.Opis, egzemplarz.Pojemnosc, egzemplarz.Fotel, Ceny.T1(pojemnosc));
        }
    }
}
