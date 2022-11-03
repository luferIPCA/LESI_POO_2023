/** 
 * lufer
 * POO - LESI-PL
 * Proposta de resolução do exercício do slide 27 de LESI_POO_5_PILLARS
 *
 *  Classes:
 *      Biblioteca
 *      Utilizador
 *      Obra
 */

using System;


namespace ExercSlides
{
    /// <summary>
    /// Classse que descreve uma Biblioteca
    /// </summary>
    class Biblioteca
    {

        const int MAXUTIL = 20;
        const int MAXOBRAS = 100;
        string inst;
        Utilizador[] users;
        Obra[] obras;
        
        Obras variasObras;

        public static int totUtilizadores=0;
        public static int totObras = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        public Biblioteca(string n)
        {
            inst = n;
            users = new Utilizador[MAXUTIL];
            obras = new Obra[MAXOBRAS];
        }
        /// <summary>
        /// 
        /// </summary>
        public string Inst
        {
            get;
            set;
        }

        /// <summary>
        /// Regista novo utilizador na biblioteca
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool RegistaUtilizador(Utilizador u)
        {
            //inserir num array..
            users[totUtilizadores++] = u;   //Verfificar se não existe
            return true;
        }

        /// <summary>
        /// Regista nova obra na biblioteca
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool RegistaObra(Obra o)
        {
            obras[totObras++]= o;
            return true;
        }

        public void MostraObras()
        {
            for(int i=0; i<totObras; i++)
            {
                Console.WriteLine("Obra: {0} - Autor: {1}", obras[i].Titulo, obras[i].GetFirstAutor());
            }
        }


        #region GERE_OBRAS
        public bool InsereObra(Obra o)
        {
            //testar se já existe
            obras[totObras++] = o;
            return true;
        }
        #endregion
    }


    class Obras
    {
        Obra[] obras;
        int totObras = 0;


        public bool InsereObra(Obra o)
        {
            //testar se já existe
            obras[totObras++] = o;
            return true;
        }
    }
}
