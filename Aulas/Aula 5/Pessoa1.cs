
//by lufer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5
{
    /// <summary>
    /// 
    /// </summary>
    class Pessoa
    {
        #region ESTADO
        
        int idade;
        string nome;
        
        #endregion

        #region COMPORT

        #region CONST
        /// <summary>
        /// Por omissão
        /// </summary>
        public Pessoa()
        {
            idade = 0;
            nome = "";
        }

        public Pessoa(int i, string n)
        {
            idade = i;
            nome = n;
        }

        public Pessoa(string nome, int idade)
        {
            this.idade = idade;
            this.nome = nome;
        }
        #endregion

        #region PROPERT

        public int Idade
        {
            set{ if (value>0) idade = value; } 
            get { return idade; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        #endregion
        public bool SetIdade(int i)
        {
            if (i > 0)
            {
                idade = i;
                return true;
            }
            return false;
        }

        public int GetIdade()
        {

            return idade;
        }

        #endregion

    }
}
