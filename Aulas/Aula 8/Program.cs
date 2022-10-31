using System;

namespace Aula_8
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Polimorfismo
            Veiculo v1 = new Veiculo();
            v1.Ano = 1998;      //set

            Veiculo v2 = new Veiculo(1998);
            v2.Ano = 2022;
            #endregion

            #region OverriteMetodos

            Console.WriteLine("Ano: " + v1.Ano.ToString());    //get
            Console.WriteLine(v1.ToString());

            #endregion

            #region Herança

            Carro c1 = new Carro();
            Carro c2 = new Carro("aaa",1234);

            Veiculo v3 = new Carro("Skoda");
            v3.GetVeiculoDetais();

            #endregion

            CarroASerio aa = new CarroASerio();


            Nova n = new Nova();

            //Veiculo.FazCoisas(n);

            Console.ReadKey();
        }
    }
}
