/*
 * author: lufer
 * email:
 * */
using System;

namespace Aula_2
{ 
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    /// <example>
    /// </example>
    class MainAula
    {
        /// <summary>
        /// Método de classe: static
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int Soma(int x, int y)
        {
            return (x + y);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Variaveis

            int idade;          //auxiliar para
            bool x;
            string valor;

            #endregion

            #region Coisas
            Console.Write("Idade: ");

            valor = Console.ReadLine();
            //idade = int.Parse(valor);

            //DateTime hoje = DateTime.Parse(valor);
            //double aux = double.Parse(valor);

            x = int.TryParse(valor,out idade);

            if(x==false)
            {
                Console.WriteLine("0");
            }

            //idade = int.Parse(Console.ReadLine());


            else
                Console.WriteLine("A sua idade:" + idade);
            //printf(""A soma de %d com %d = %d\n",1,3,Soma(1,3));
            Console.WriteLine("A soma de {0} com {1} = {2}\n",1,3,Soma(1,3));

            Pessoa.Soma(2, 3);

            #endregion
        }
    }
}
