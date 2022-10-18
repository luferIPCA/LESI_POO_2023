using System;

namespace Aula_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p;
            p = new Pessoa();
            //p.idade = -7;
            
            //A la JAVA
            p.SetIdade(-7);
            Console.WriteLine("Idade: "+ p.GetIdade().ToString());
            
            //A la C#
            p.Idade = 2;
            Console.WriteLine("Idade: " + p.Idade);


            Pessoa p1 = new Pessoa(12, "ola");
            Pessoa p2 = new Pessoa("Maria", 27);

            Console.ReadKey();
        }
    }
}
