using System;

namespace Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            Kostka sestistenna = new Kostka(); 
            Kostka desetistenna = new Kostka(10);
            
            Console.WriteLine(sestistenna);
            for (int i = 0; i <10; i++)
                Console.Write(sestistenna.hod() + " ");

            Console.WriteLine("\n\n" + desetistenna);
            for (int i = 0; i <10;i++)
                Console.Write(desetistenna.hod() + " ");

            Console.ReadKey();
        }
    }
}
