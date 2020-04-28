using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonfiguratorAut
{
    class T2_SuperBike : T1_Motory
    {
        public double Moc { get; protected set; }
        public T2_SuperBike(double pojemnosc, double moc, int fotel = 1, string opis = "Ścigacz") : base(pojemnosc, fotel, opis)
        {
            this.Moc = moc;
        }
        public new static void Parametry()
        {
            Console.Write("Podaj pojemność z zakresu 500-1100: ");
            double pojemnosc = double.Parse(Console.ReadLine());

            Console.Write("Podaj moc z zakresu 90-160: ");
            double moc = double.Parse(Console.ReadLine());

            T2_SuperBike egzemplarz = new T2_SuperBike(pojemnosc, moc);

            Console.WriteLine("---------------------");
            Console.WriteLine("{0} o pojemności {1} cm3, mocy {4} KM i fotelu {2} osobowym będzie Pana kosztował {3} PLN", egzemplarz.Opis, egzemplarz.Pojemnosc, egzemplarz.Fotel, Ceny.T2(pojemnosc), egzemplarz.Moc);
        }
    }
}
