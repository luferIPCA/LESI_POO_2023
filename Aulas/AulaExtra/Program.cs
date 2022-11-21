using System;

namespace AulaExtra
{
    class Program
    {
        static void Main(string[] args)
        {
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
