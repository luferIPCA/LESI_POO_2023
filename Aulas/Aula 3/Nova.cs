/** 
 */

using System;

namespace Aula_3
{
    class Nova
    {
        static void Main(string[] args)
        {
            #region C
            //if
            int a = 7;
            if (a > 7)
            {
                a++;
            }

            //for
            for(int i=0; i<a; i++)
            {
                i += a;
            }

            //do
            do
            {
                a++;
            } while (a < 20);

            //switch

            switch (a)
            {
                case 101: //...
                        break;
                case 2: //...
                        break;
                default:
                    break;
            }
            //?

            if (a > 7)
                a = 2;
            else
            {
                a = 3;
            }

            a = (a > 7) ? 2 : 3;

            //variáveis
            string nome;
            string[] turma;

            //constantes
            const int Raio = 20;

            #endregion

            #region Arrays

            //Inteiros
            //C: int valores[10];
            int[] valores= { 1, 2, 3, 4, 5 };
           

            //Percorre todas as posições
            for(int i=0; i < valores.Length; i++)
            {
                Console.WriteLine("i=" + valores[i].ToString());
            }

            //Percorre todos os valores
            foreach(int x in valores)
            {
                Console.WriteLine("i=" + x.ToString());
            }

            //STrings
            string[] clubes = { "Venfica", "portinhoooo", "Braguinha" };
            
            foreach (String s in clubes)
            {
                Console.WriteLine("Clube=" + s);
            }

            //Ordenar
            //Procurar
            //Existe valor a no array?

            //int[][] x;
            //int[,] y;

            bool existe = false;
            for(int i=0; i<valores.Length; i++)
            {
                //if (valores[i]%2==0) cont++;
                if(valores[i]==a)
                {
                    existe = true;
                    break;
                }
            }
            if (existe==true) 
                Console.WriteLine("Existe"); 
            else 
                Console.WriteLine("Não");
            
            
            existe = false;
            foreach(int x in valores)
            {
                if (x == a)
                {
                    existe = true;
                    break;
                }
            }
            if (existe == true)
                Console.WriteLine("Existe");
            else
                Console.WriteLine("Não");


            //Metodo desta classe
            MostraArray(clubes);

            //Metodo de outra classe
            Outra.MostraArrayII(clubes);
            //Metodo de outra classe
            OutraDif.Soma(2, 3);

            #endregion

        }

        static void MostraArray(string[] n)
        {
            foreach(string s in n)
            {
                Console.WriteLine(s);
            }
        }
    }


    // class Outra
    //{
    //    public static void MostraArrayII(string[] n)
    //    {
    //        foreach (string s in n)
    //        {
    //            Console.WriteLine(s);
    //        }
    //    }
    //}
}
