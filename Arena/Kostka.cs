using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    class Kostka
    {
        /// <summary>
        /// Generátor náhodných čísel
        /// </summary>
        private Random random;
        /// <summary>
        /// Počet stěn kostky
        /// </summary>
        private int pocetSten;
        public Kostka()
        {
            pocetSten = 6;
            random = new Random();
        }
        public Kostka(int pocetSten)
        {
            this.pocetSten = pocetSten;
            random = new Random();
        }
        /// <summary>
        /// Hodí kostkou
        /// </summary>
        /// <returns>Číslo od 1 do počtu stěn</returns>
        public int hod()
        {
            return random.Next(1, pocetSten + 1);
        }
        public int VratPocetSten()
        {
            return pocetSten;
        }
        /// <summary>
        /// Vrací textovou reprezentaci kostky
        /// </summary>
        /// <returns>Textová reprezentace kostky</returns>
        public override string ToString()
        {
            return string.Format("Kostka s {0} stěnami", pocetSten);
        }
    }
}
