using System;

namespace AulaExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ATENDIMENTO

            //h1
            Pessoa p1 = new Pessoa();
            p1.Idade = 20;      //set
            p1.Nome = "Maria";

            //h2
            Pessoa p2 = new Pessoa(20, "Maria");

            //h3
            Pessoa p3 = new Pessoa("Paula", new DateTime(12, 12, 1980));
            Console.WriteLine("Idade: {0}\n",p3.Idade);


            Pessoas pes = new Pessoas(100);
            pes.InserePessoa(p1);
            pes.InserePessoa(p2);
            pes.InserePessoa(p3);
            Console.WriteLine("Total Pessoas: {0}\n", pes.Quantas);
            
            #endregion


            //a)
            int x;
            Converte a;
            a = new Converte(); //criar em memória espaço para o objeto a

            double f = a.C2F(12.0);
            Console.WriteLine("12 C = {0}F", f.ToString());

            //b h1: Mostra de 100 a -10
            for (int i=100;i>=-10; i--)
            {
                Console.Write("{0} C = {1} F\n", i.ToString(), a.C2F(i).ToString());
            }
            //b h2
            
            MostraValores(100, -10, (int)f);
            
        }
        //SOLID
        static void MostraValores(int inicio, int fim, int x)
        {
            Converte a = new Converte();
            //b Mostra de 100 a -10
            for (int i = inicio; i >= -10; i--)
            {
                Console.Write("{0} graus C = {1} F\n", i.ToString(), a.C2F(i).ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public double C2F(double c)
        {
            //
            return (c);
        }
    }
}
