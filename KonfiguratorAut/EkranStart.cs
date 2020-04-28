using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonfiguratorAut
{
    class EkranStart
    {
        public static void Logowanie()
        {
        Etykieta1:
            Console.Write("Podaj login (admin): ");
            string userLog = Console.ReadLine();

            if (PasLog.Login() == userLog)
            {
            Etykieta2:
                Console.Write("\nUżytkownik znany, podaj hasło (123): ");
                string userPass = Console.ReadLine();
                if (PasLog.Haslo() == userPass)
                {
                    Console.WriteLine("Hasło poprawne");
                }
                else
                {
                    Console.WriteLine("\tHasło niepoprawne!");
                    goto Etykieta2;
                }
            }
            else
            {
                Console.WriteLine("\tUżytkownik nieznany!");
                goto Etykieta1;
            }
            Console.Clear();
            Console.WriteLine("WITAJ {0} w konfiguratorze pojazdów", userLog);
        }
    }
}

