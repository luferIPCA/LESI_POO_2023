/**
 * Resolução do Teste de POO - 2020-2021
 * Data
 * email
 * 
 * */
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Teste_2020_2021
{
    /// <summary>
    /// descreve uma Pessoa
    /// </summary>
    class Pessoa
    {
        int nc;
        string nome;

        [NonSerialized]
        DateTime dn;

        public int Nc
        {
            get;
            set;
        }
        public string Nome
        {
            get;
            set;
        }

        /// <summary>
        /// Reescreve o método Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Pessoa nova = obj as Pessoa;
            return ((nova.Nome == this.Nome) && (nova.Nc == this.Nc));
        }

        /// <summary>
        /// Novo Operador "=="
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            return p1.Equals(p2);
        }


        /// <summary>
        /// Novo operador "!="
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            return !(p1==p2);
        }

    }

    /// <summary>
    /// Descreve uma visita ao museu
    /// </summary>
    class Visita
    {
        Pessoa p;
        DateTime dia;

        public Pessoa P
        {
            get { return p; }
            set { p = value; }
        }
    }

    /// <summary>
    /// descreve um Museu..
    /// 
    /// </summary>
    class Museu
    {
        string nome;
        ArrayList visitantes;       //conjunto de "Visita"

        [NonSerialized]
        int totVisitantes;

        public Museu(string nome)
        {
            this.nome = nome;
            visitantes = new ArrayList();
            totVisitantes = 0;
        }

        /// <summary>
        /// Verifica se já visitou o museu
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        bool PodeVisitar(string nome)
        {
            //
            return true;
        }

        /// <summary>
        /// Visita
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        bool VisitaMuseu(Visita v)
        {
            if (PodeVisitar(v.P.Nome) == false) return false;
            visitantes.Add(v);
            return true;
        }

        public  bool SaveAll(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream,visitantes);
                stream.Close();
                return true;
            }
            catch (IOException e)
            { 
                throw e;
            }
        }
    }
}
