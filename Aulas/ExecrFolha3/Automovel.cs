
//by lufer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercFolha3
{


    class Automovel
    {
        #region ESTADO

        string matricula;
        //string modelo;
        byte combustivel;
        //string cor;
        short ano;

        #endregion

        #region METODOS

        #region CONST
        public Automovel()
        {
            ano = 2022;
            combustivel = 1;    //Gasolina
        }

        public Automovel(string mat, byte comb, short a)
        {
            matricula = mat;
            combustivel = comb;
            ano = a;
        }

        #endregion

        public short Ano
        {
            get;
            set;
        }

        #region OUTROS_METODOS

        /// <summary>
        /// Calcula o custo do automóvel...
        /// </summary>
        /// <returns></returns>
        public double Custo()
        {
            double custo;

            switch (combustivel)
            {
                case 1:  custo = 12000; break;
                case 2: custo = 13000;break;
                case 3: custo = 14000;break;
                case 4: custo = 15000;break;
                default: custo = 0;break;

            }
            return (custo);
        }
        #endregion

        #endregion
    }
}
