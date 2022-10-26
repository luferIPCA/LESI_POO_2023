using System;

namespace Aula_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v1 = new Veiculo();
            v1.Ano = 1998;      //set

            Veiculo v2 = new Veiculo(1998);
            v2.Ano = 2022;  

            Console.WriteLine("Ano: " + v1.Ano.ToString());    //get
            Console.WriteLine(v1.ToString());

            Carro c1 = new Carro();

            Veiculo v3 = new Carro("Skoda");
            v3.GetVeiculoDetais();

            Console.ReadKey();
        }
    }
}
