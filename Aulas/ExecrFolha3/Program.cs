using System;

namespace ExercFolha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovel a1 = new Automovel("12-12-12", 1, 2022);
            Console.WriteLine("Custo:" + a1.Custo().ToString());
        }
    }
}
