
//by lufer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerFolha3
{

    public enum COMB
    {
        GAZ,
        GAS,
        ELE
    }
    public class Automovel  : IComparable
    {
        #region ESTADO

        string matricula;
        //string modelo;
        byte combustivel;
        COMB c;
        //string cor;
        short ano;

        #endregion

        #region METODOS

        #region CONST
        public Automovel()
        {
            ano = 2022;
            combustivel = 1;    //Gasolina
            //Veiculos.InsVeiculo(this);
        }

        public Automovel(string mat, byte comb, short a, COMB c)
        {
            Matricula = mat;
            combustivel = comb;
            Ano = a;
            this.c = c;
            //Veiculos.InsVeiculo(this);
        }

        #endregion

        public short Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string Matricula
        {
            set { matricula = value; }
            get { return matricula; }       
        }

        #region OUTROS_METODOS

        /// <summary>
        /// Calcula o custo do automóvel...
        /// </summary>
        /// <returns></returns>
        public virtual double Custo()
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

        public int Compare(Automovel a)
        {
            if (this.Ano > a.Ano) return 1;
            if (this.ano < a.Ano) return -1;
            return 0;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Automovel || obj is AutomovelLuxo)
            {
                Automovel aux = obj as Automovel;
                if (this.Ano == aux.ano) return 0;
                if (this.Ano > aux.ano) return 1;
                return -1;
            }
            return -1;
        }

        public bool EstacionaCarro()
        {
            if (this.Custo() >0)
            {
                throw new AutomovelInvalidoException("Carro muito caro");
            }
            return Garagem.EstacionaCarro(this);

        }

        public override string ToString()
        {
            string outStr = String.Format("Matricula: {0}\t Ano: {1}\t Combustivel: {2}\n", Matricula, Ano, combustivel);
            return outStr;
        }
        #endregion

        public static bool operator ==(Automovel a1, Automovel a2)
        {
            //if (a1.Matricula.CompareTo(a2.Matricula) == 0) return true;
            //return (false);
            return (a1.Equals(a2));
        }
        public static bool operator !=(Automovel a1, Automovel a2)
        {
            return (!(a1 == a2));
        }

        public override bool Equals(object obj)
        {
            Automovel a = obj as Automovel;
            return (this.Matricula.CompareTo(a.Matricula) == 0);
        }


        #endregion
    }
}
