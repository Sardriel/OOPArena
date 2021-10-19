using System;

namespace Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kostka kostka = new Kostka(20);
            Bojovnik sardriel = new Bojovnik("Sardriel", 100, 20, 10, kostka);
            Bojovnik watashi = new Bojovnik("Watashi wa M", 60, 18, 15, kostka);
            Arena arena = new Arena(sardriel, watashi, kostka);

            arena.Zapas();
            Console.ReadKey();
        }
    }
}
