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


/*
 * Classifica o tipo de obra
 * */
public enum TIPOOBRA
{
    cientificos, 
    revistas, 
    informativas, 
    jornais, 
    entretenimento
}


namespace ExercSlides
{

    /// <summary>
    /// Descreve um autor
    /// </summary>
    class Autor
    {
        string nome;
        int ano;

        public string Nome
        {

            get { return nome; }
            set
            {
                nome = value;
            }
        }
    }

    /// <summary>
    /// Descreve um conjunto de autores
    /// </summary>
    class Autores
    {
        Autor[] varios;
        public int totAutores;
        const int MAXAUTORES = 10;

        #region Metodos

        public Autores()
        {
            varios = new Autor[MAXAUTORES];
            totAutores = 0;
        }

        /// <summary>
        /// Insere novo autor
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool InsereAutor(Autor a)
        {
            //Se já existir, return false;
            varios[totAutores++] = a;
            return true;
        }

        public Autor GetFirstAutor()
        {
            return varios[0];
        }

        //Consula autor
        //Lista autores
        //etc.

        #endregion
    }

    /// <summary>
    /// Descreve uma Obra da biblioteca
    /// </summary>
    class Obra
    {
        string titulo;
        TIPOOBRA tipo;
        string idioma;
        string formato;
        Autores varios; //Vários autores
        //Autor a;        //apenas 1 autor
        string editora; //vamos supor apenas  uma editora


        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public Obra(TIPOOBRA t)
        {
            tipo = t;
            varios = new Autores();
        }

        /// <summary>
        /// Regista novo autor na obra corrente
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool InsereAutorObra(Autor a)
        {
            bool aux =varios.InsereAutor(a);
            return aux;
        }

        public string GetFirstAutor()
        {
                return varios.GetFirstAutor().Nome;
        }
    }
}
