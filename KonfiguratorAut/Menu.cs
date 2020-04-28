using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonfiguratorAut
{
    class Menu
    {
        public static void Wybor()
        {
        ponownyWybor:
            Console.WriteLine("Proszę wybrać rodzaj pojazdu:\n");

            Console.Write("\t 1 - SKUTERY \n\t 2 - SUPER BIKE \n\t 3 - AUTA OSOBOWE \n\t 4 - AUTA CIĘŻAROWE \n\t 5 - koniec programu");
            Console.Write("\n\t");
            int wybor = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (wybor)
            {
                case 1:
                    T1_Motory.Parametry();
                    break;
                case 2:
                    T2_SuperBike.Parametry();
                    break;
                case 3:
                    R1_Auta.Parametry();
                    break;
                case 4:
                    R2_BigAuta.Parametry();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Upss, nie ten wybór");
                    goto ponownyWybor;
            }
        }
    }
}
