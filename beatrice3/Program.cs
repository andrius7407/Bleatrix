using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beatrice3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite kiek kartu Beatričė kartos uzduoti");
            int sugalvotasSkaicius = Convert.ToInt32(Console.ReadLine());
            if(sugalvotasSkaicius == 0)
            {
                Console.WriteLine("insomnia");
            }
            else
            {
                int kartai = KiekKartuPadides(sugalvotasSkaicius);
                IsvedimasIKonsole(sugalvotasSkaicius, kartai);
            }
            Console.ReadKey();
        }

        public static int KiekKartuPadides(int sugalvotasSkaicius)
        {
            int nulis = 0;
            int vienas = 0;
            int du = 0;
            int trys = 0;
            int keturi = 0;
            int penki = 0;
            int sesi = 0;
            int septyni = 0;
            int astuoni = 0;
            int devyni = 0;
            int suma = 0;
            int padidintasSkaicius = 0;
            int kartai = 0;
            while (suma < 55)
            {
                padidintasSkaicius += sugalvotasSkaicius;
                int skaiciusTikrinamas = padidintasSkaicius;
                while (skaiciusTikrinamas > 0)
                {
                    int liekana = skaiciusTikrinamas % 10;
                    if (liekana == 0)
                    {
                        nulis = liekana + 10;
                    }
                    if (liekana == 1)
                    {
                        vienas = liekana;
                    }
                    if (liekana == 2)
                    {
                        du = liekana;
                    }
                    if (liekana == 3)
                    {
                        trys = liekana;
                    }
                    if (liekana == 4)
                    {
                        keturi = liekana;
                    }
                    if (liekana == 5)
                    {
                        penki = liekana;
                    }
                    if (liekana == 6)
                    {
                        sesi = liekana;
                    }
                    if (liekana == 7)
                    {
                        septyni = liekana;
                    }
                    if (liekana == 8)
                    {
                        astuoni = liekana;
                    }
                    if (liekana == 9)
                    {
                        devyni = liekana;
                    }
                    skaiciusTikrinamas = skaiciusTikrinamas / 10;
                }
                if (nulis + vienas + du + trys + keturi + penki + sesi + septyni + astuoni + devyni == 55)
                {
                    break;
                }
                kartai++;
            }
            return kartai;
        }

        private static void IsvedimasIKonsole(int sugalvotasSkaicius, int kartai)
        {
            Console.WriteLine("Beatričė užmigs, kai pasakys {0} - {1}x{2}", sugalvotasSkaicius * (kartai + 1), kartai + 1, sugalvotasSkaicius);
            for (int i = 0; i < sugalvotasSkaicius; i++)
            {
                Console.WriteLine("iveskite Beatričės sugalvotą skaičių");
                int sugalvotas2 = Convert.ToInt32(Console.ReadLine());
                if (sugalvotas2 == 0)
                {
                    Console.WriteLine("insomnia");
                }
                else
                {
                    int kartai2 = KiekKartuPadides(sugalvotas2);
                    Console.WriteLine("Beatričė užmigs, kai pasakys {0} - {1}x{2}", sugalvotas2 * (kartai2 + 1), kartai2 + 1, sugalvotas2);
                }
            }
        }
    }
}
