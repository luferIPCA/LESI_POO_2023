using System;

namespace Aula_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro c = new Carro();
            //Carro c2 = new Carro(2023);
            c.Ano = -20;

            Carro c2 = new Carro();

            //Console.WriteLine("Ano: {0} - Total de Carros {1}",c.Ano.ToString(),c.TotCarros().ToString());
            Console.WriteLine("Ano: {0} - Total de Carros {1}", c.Ano.ToString(), Carro.GetTotCarros().ToString());
            Console.WriteLine("Ano: {0} - Total de Carros {1}", c.Ano.ToString(), Carro.GetTotCarrosProp.ToString());
        }
    }
}
