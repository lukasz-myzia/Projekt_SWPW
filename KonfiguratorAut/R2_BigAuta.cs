using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonfiguratorAut
{
    class R2_BigAuta : R1_Auta
    {
        public int MomentObrotowy { get; protected set; }
        public int LiczbaOsi { get; protected set; }
        public R2_BigAuta(int moc, int liczbaOsi, double pojemnosc, int momentObrotowy, string opis) : base(pojemnosc, moc, opis)
        {
            this.MomentObrotowy = momentObrotowy;
            this.LiczbaOsi = liczbaOsi;
        }
        public new static void Parametry()
        {
            Console.WriteLine("posiadamy jedno auto ciężarowe o takich paramterach: ");

            string[,] tablicaParametrów = new string[5, 2];
            tablicaParametrów[0, 0] = "MOC";
            tablicaParametrów[0, 1] = "430";
            tablicaParametrów[1, 0] = "Liczba osi";
            tablicaParametrów[1, 1] = "4";
            tablicaParametrów[2, 0] = "Pojemność";
            tablicaParametrów[2, 1] = "10,518";
            tablicaParametrów[3, 0] = "Moment Obrotowy";
            tablicaParametrów[3, 1] = "2100";
            tablicaParametrów[4, 0] = "Opis";
            tablicaParametrów[4, 1] = "Scania";

            R2_BigAuta egzemplarz = new R2_BigAuta(int.Parse(tablicaParametrów[0, 1]), int.Parse(tablicaParametrów[1, 1]), double.Parse(tablicaParametrów[2, 1]), int.Parse(tablicaParametrów[3, 1]), tablicaParametrów[4, 1]);

            foreach (string element in tablicaParametrów)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine("{0} jest dostęna od ręki w cenie {1} PLN", egzemplarz.Opis, Ceny.R2(double.Parse(tablicaParametrów[2, 1])));
        }
    }
}
