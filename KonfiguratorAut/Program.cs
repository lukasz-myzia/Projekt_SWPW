using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonfiguratorAut
{
    class Program
    {
        static void Main(string[] args)
        {
            EkranStart.Logowanie();

            int exit = 0;
            while (exit != 2)
            {
                Menu.Wybor();
                Console.WriteLine("\n Naciśnij dowolny aby kontynuować");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\n 1 - Początek PROGRAMU");
                Console.WriteLine("\n 2 - KONIEC PROGRAMU");
                exit = int.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
