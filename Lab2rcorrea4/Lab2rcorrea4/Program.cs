using System;

namespace Lab2rcorrea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion("layla","album1","Eric Clapton","Rock");
            string inf = cancion1.Infor();
            Console.WriteLine(inf);
            Console.ReadLine();
        }
    }
}
