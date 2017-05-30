using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondenNaarTijd
{
    struct UMSTijd
    {
        public int h;
        public int m;
        public int s;   
    }

    public class Tijd
    {
        private int uur;
        private int min;
        private int sec;
        private int rest = 0;
        
        public Tijd(int aantalSec)
        {
            uur = aantalSec / 3600;
            rest = aantalSec % 3600;
            min = rest / 60;
            sec = rest % 60;
        }

        public void ToonTijd()
        {
            Console.WriteLine("{0} u(u)r(en); {1} minu(u)t(en); {2} second(en)", uur, min, sec);
        }

        public int Uren { get { return uur; } }
        public int Minuten { get { return min; } }
        public int Seconden { get { return sec; } }
    }

    class Program
    {
        private static void SecNaarUrenMinutenSeconden(int totaalSeconden, out int uren, out int minuten, out int seconden) //output-parameters vermijden: ze zijn lelijk
        {
            //tijdelijke tussentijdse variabele
            int rest = 0;

            //algoritme:
            uren = totaalSeconden / 3600;
            rest = totaalSeconden % 3600;
            minuten = rest / 60;
            seconden = rest % 60;
        }

        private static UMSTijd SecNaarUMS(int totaalSeconden)
        {
            UMSTijd nieuweTijd;
            int rest = 0;

            nieuweTijd.h = totaalSeconden / 3600;
            rest = totaalSeconden % 3600;
            nieuweTijd.m = rest / 60;
            nieuweTijd.s = rest % 60;

            return nieuweTijd;
        }

        static void Main(string[] args)
        {
            //int h = 0;
            //int m = 0;
            //int s = 0;

            //SecNaarUrenMinutenSeconden(61, out h, out m, out s);
            //Console.WriteLine("{0} hours; {1} minutes; {2} seconds", h, m, s);

            UMSTijd ums = SecNaarUMS(61);
            Console.WriteLine("{0} u(u)r(en); {1} minu(u)t(en); {2} second(en)", ums.h, ums.m, ums.s);

            Tijd uurMinuutSecond = new Tijd(61);
            uurMinuutSecond.ToonTijd();
        }
    }
}