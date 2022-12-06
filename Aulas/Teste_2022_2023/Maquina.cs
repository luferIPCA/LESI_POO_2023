/*
*	<copyright file="Teste_2022_2023.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/28/2022 9:25:29 AM</date>
*	<description></description>
**/
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Teste_2022_2023
{

    public enum Tarefa
    {
        CORTAR,
        LIMPAR,
        SOLDAR
    }

    public enum Estado
    {
        OPERACIONAL,
        AVARIADA,
        MANUTENCAO,
        OCUPADA
    }

    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/28/2022 9:25:29 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Maquina
    {
        #region Attributes
        public int cod;     //atenção aos public...tem de ser private!
        DateTime manutencao;
        public Tarefa tarefa;
        public Estado estado;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Maquina()
        {
            manutencao = DateTime.Now;
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        //Operador == e !=
        public static bool operator ==(Maquina m1, Maquina m2)
        {     
            return (m1.cod==m2.cod && m1.tarefa==m2.tarefa);
        }
        public static bool operator !=(Maquina m1, Maquina m2)
        {
            return (!(m1==m2));
        }
        //Equals
        public override bool Equals(object obj)
        {
            return (this==((Maquina)obj));
        }

        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Maquina()
        {
        }
        #endregion

        #endregion
    }

    [Serializable]
    public class LinhaProducao
    {
        const int MAXMAQ = 20;
        public ArrayList maquinas;
        [NonSerialized]
        int totMaquinas;
        public int codLinhaProducao;

        public LinhaProducao()
        {
            maquinas = new ArrayList();
            totMaquinas = 0;
        }

        public bool AddMaquina(Maquina m)
        {
            if((totMaquinas<MAXMAQ) && (!maquinas.Contains(m))){
                maquinas.Add(m);return true;
            }
            return false;
        }

        public ArrayList QuaisMaquinas(Tarefa t, Estado e) {
            ArrayList maq = new ArrayList();
            foreach(Maquina x in maquinas)
            {
                if ((x.tarefa == t) && (x.estado == e)) maq.Add(x);
            }
            return maq;
        }

        public ArrayList QuaisMaquinasEstado(Estado e)
        {
            ArrayList maq = new ArrayList();
            foreach (Maquina x in maquinas)
            {
                if (x.estado == e) maq.Add(x);
            }
            return maq;
        }

    }

    [Serializable]
    public class Empresa : TipoEmpresa
    {
        public ArrayList linhasProducao;
        int totLinhasProducao;
        static string nomeEmpresa;

        public Empresa(string nome)
        {
            if (nomeEmpresa == null)
            {
                linhasProducao = new ArrayList();
                totLinhasProducao = 0;
                nomeEmpresa = nome;
            }
        }

        public override bool CriaLinhaProducao(LinhaProducao l)
        {
            if (linhasProducao.Contains(l)) return false;
            linhasProducao.Add(l);
            totLinhasProducao++;
            return true;
        }

        /// <summary>
        /// Insere maquina nova numa linha de produção
        /// </summary>
        /// <param name="codLinha"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public bool AddMaquinaLinhaProducao(int codLinha, Maquina m)
        {
            foreach(LinhaProducao lp in linhasProducao)
            {
                if (lp.codLinhaProducao == codLinha)
                {
                    return lp.AddMaquina(m);
                }
            }
            return false;
        }

        public override ArrayList MaquinasEstadoLinhaProducao(int codLinha, Estado e)
        {
            ArrayList prod = new ArrayList();
            foreach(LinhaProducao p in linhasProducao)
            {
                if (p.codLinhaProducao == codLinha)
                {
                    prod=p.QuaisMaquinasEstado(e);
                }
            }
            return prod;
        }

        public bool SaveAll(string fileName)
        {
           try
            {
                    Stream s = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(s, linhasProducao);
                    s.Flush();
                    s.Close();
                    s.Dispose();
            }
            catch (Exception e)
            {
                    throw; //algo se passou
            }
            return true;
        }

    }

    public abstract class TipoEmpresa
    {
        /// <summary>
        /// Cria uma nova linha de produção na empresa
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public abstract bool CriaLinhaProducao(LinhaProducao l);
        /// <summary>
        /// Devolve o conjunto de máquinas de uma linha de produção, de uma empresa 
        /// que se encontram em determinado estado
        /// </summary>
        /// <param name="codLinha"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public abstract ArrayList MaquinasEstadoLinhaProducao(int codLinha, Estado e);
    }
}
