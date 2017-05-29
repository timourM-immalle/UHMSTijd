using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondenNaarTijd
{
    class Program
    {
        private static void SecNaarUrenMinutenSeconden(int totaalSeconden, out int uren, out int minuten, out int seconden)
        {
            //tijdelijke tussentijdse variabele
            int rest = 0;

            //algoritme:
            uren = totaalSeconden / 3600;
            rest = totaalSeconden % 3600;
            minuten = rest / 60;
            seconden = rest % 60;
        }

        static void Main(string[] args)
        {
            int h = 0;
            int m = 0;
            int s = 0;

            SecNaarUrenMinutenSeconden(61, out h, out m, out s);
            Console.WriteLine("{0} hours; {1} minutes; {2} seconds", h, m, s);
        }
    }
}