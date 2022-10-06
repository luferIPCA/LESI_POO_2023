/**
 * Classes e Objetos
 * lufer
 */
using System;

namespace Aula_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UM
            int[] valores = { 7, 6, -1, 11, 0 };
            double av;
            av = Opers.CalculaMedia(valores);

            int x, y;
            x = 2; y = 3;
            int aux = Opers.Soma(y,x);
            #endregion

            Pessoa p;       //p é um objeto do tipo Pessoa
            p = new Pessoa();

            //p.idade = 12;
            p.nome = "Ok";


            Pessoa q = new Pessoa();
            q.idade = p.idade * 2;


        }


    }
}
