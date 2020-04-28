using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonfiguratorAut
{
    class Ceny
    {
        public static double T1(double pojemnosc)
        {
            double przelicznik = 11;
            return przelicznik * pojemnosc;
        }
        public static double T2(double pojemnosc)
        {
            double przelicznik = 22;
            return przelicznik * pojemnosc;
        }
        public static double R1(double pojemnosc)
        {
            double przelicznik = 33333;
            return przelicznik * pojemnosc;
        }
        public static double R2(double pojemnosc)
        {
            double przelicznik = 44444;
            return przelicznik * pojemnosc;
        }
    }
}
