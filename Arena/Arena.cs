using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arena
{
    class Arena
    {
        private Bojovnik bojovnik1;
        private Bojovnik bojovnik2;
        private Kostka kostka;

        public Arena (Bojovnik bojovnik1, Bojovnik bojovnik2, Kostka kostka)
        {
            this.bojovnik1 = bojovnik1;
            this.bojovnik2 = bojovnik2;
            this.kostka = kostka;
        }

        private void Vykresli()
        {
            Console.Clear();
            Console.WriteLine("----------Aréna----------\n");
            Console.WriteLine("Bojovníci: \n");
            VypisBojovnika(bojovnik1);
            Console.WriteLine();
            VypisBojovnika(bojovnik2);
            Console.WriteLine();
        }
        private void VypisZpravu(string zprava)
        {
            Console.WriteLine(zprava);
            Thread.Sleep(500);
        }
        public void Zapas()
        {
            Bojovnik b1 = bojovnik1;
            Bojovnik b2 = bojovnik2;
            Console.WriteLine("Vítejte v aréně!");
            Console.WriteLine("Dnes se utkají {0} s {1}! \n", bojovnik1, bojovnik2);

            bool zacinaBojovnik2 = (kostka.hod() <= kostka.VratPocetSten() / 2);
            if (zacinaBojovnik2)
            {
                b1 = bojovnik2;
                b2 = bojovnik1;
            }
            Console.WriteLine("Začínat bude {0} \nZápas může začít...", b1);
            Console.ReadKey();
            while (b1.Nazivu() && b2.Nazivu())
            {
                b1.Utoc(b2);
                Vykresli();
                VypisZpravu(b1.VratPosledniZpravu());
                VypisZpravu(b2.VratPosledniZpravu());
                if (b2.Nazivu())
                { 
                b2.Utoc(b1);
                Vykresli();
                VypisZpravu(b2.VratPosledniZpravu());
                VypisZpravu(b1.VratPosledniZpravu());
                }
            }
        }

        private void VypisBojovnika(Bojovnik b)
        {
            Console.WriteLine(b);
            Console.Write("Život: ");
            Console.WriteLine(b.GrafickyZivot());
            if (b is Mag)
            {
                Console.Write("Mana: ");
                Console.WriteLine(((Mag)b).GrafickaMana());
            }
        }
    }
}
