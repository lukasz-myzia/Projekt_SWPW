using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonfiguratorAut
{
    class R1_Auta
    {
        public double Pojemnosc { get; protected set; }
        public int Moc { get; protected set; }
        public string Opis { get; protected set; }
        public R1_Auta(double pojemnosc, int moc, string opis)
        {
            this.Pojemnosc = pojemnosc;
            this.Moc = moc;
            this.Opis = opis;
        }
        public static void Parametry()
        {
        sss:
            Console.WriteLine("wybierz jeden z silników:");
            Console.WriteLine("\t1 - V8, 4,5 litra, 605 KM");
            Console.WriteLine("\t2 - V12, 6,5 litra, 800 KM");

            int wybor = int.Parse(Console.ReadLine());

            double pojemnosc;
            int moc;
            string opis;

            if (wybor == 1)
            {
                pojemnosc = 4.5;
                moc = 605;
                opis = "Porshe";
            }
            else if (wybor == 2)
            {
                pojemnosc = 6.5;
                moc = 800;
                opis = "Ferrari";
            }
            else
            {
                Console.WriteLine("zły wybór");
                goto sss;
            }
            R1_Auta egzemplarz = new R1_Auta(pojemnosc, moc, opis);
            Console.WriteLine("---------------------");
            Console.WriteLine("{0} o pojemności {1} cm3 będzie Pana kosztował {2} PLN", egzemplarz.Opis, egzemplarz.Pojemnosc, Ceny.R1(pojemnosc));
        }
    }
}
