using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    class Bojovnik
    {
        private string jmeno;
        private int zivot;
        private int maxZivot;
        private int utok;
        private int obrana;
        private Kostka kostka;
        private string zprava;

        public Bojovnik(string jmeno, int zivot, int utok, int obrana, Kostka kostka)
        {
            this.jmeno = jmeno;
            this.zivot = zivot;
            this.maxZivot = zivot;
            this.utok = utok;
            this.obrana = obrana;
            this.kostka = kostka;
        }
        public override string ToString()
        {
            return jmeno;
        }

        public bool Nazivu()
        {
            return (zivot > 0);
                
        }
        public string GrafickyZivot()
        {
            string s = "[";
            int celkem = 20;
            double pocet = Math.Round(((double)zivot / maxZivot) * celkem);
            if ((pocet ==0)&&(Nazivu()))
                    pocet = 1;
            for (int i = 0; i < pocet; i++)
                s += "#";
            s = s.PadRight(celkem + 1);
            s += "]";
            return s;
        }

        public void BranSe (int uder)
        {
            int zraneni = utok + kostka.hod();
            if (zraneni > 0)
            {
                zivot -= zraneni;
                zprava = String.Format("{0} utrpěl poškození {1} hp", jmeno, zraneni);
                if (zivot <= 0)
                {
                    zivot = 0;
                    zprava += " a zemřel";
                }
            }
            else
                zprava = String.Format("{0} odrazil útok", jmeno);
            NastavZpravu(zprava);
        }
        public void Utoc(Bojovnik souper)
        {
            int uder = utok + kostka.hod();
            NastavZpravu(String.Format("{0} útočí s úderem {1} hp", jmeno, uder));
            souper.BranSe(uder);
        }
        private void NastavZpravu(string zprava)
        {
            this.zprava = zprava;
        }
        public string VratPosledniZpravu()
        {
            return zprava;
        }
        
        
}

}
