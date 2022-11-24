/*
 * Revisão Classes
 * */
using System;
using System.Collections;

namespace AulaExtra
{
    class Pessoa
    {
        //atributos
        DateTime dataNascimento;

        [NonSerialized]
        int idade;

        string nome;

        //construtores
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

        public Pessoa(string n, DateTime nasc)
        {
            idade =  DateTime.Now.Year-nasc.Year;
            nome = n;
            dataNascimento = nasc;
        }

        //Propriedades
        public int Idade
        {
            set { idade = value; }
            get { return idade; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


    }


    class Pessoas
    {
        //atributos
                //Grupo de pessoas
                //h1 - Array
                //Pessoa[] p;
                //h2 - ArrayList
        ArrayList listaPessoas;   //ArrayList de "Pessoa"

        [NonSerialized]
        int totalPessoas;
                //h3 - List
                //List<Pessoa> p2;

        //construtores
        public Pessoas()
        {
            listaPessoas = new ArrayList();
            totalPessoas = 0;
        }

        public Pessoas(int size)
        {
            listaPessoas = new ArrayList(size);
            totalPessoas = 0;
        }

        //propriedades
            //Pode não ter!

        //Pode ter: por exemplo, Quantas pessoas?
        public int Quantas
        {
            get { return totalPessoas; }
        }

        //Outros Métodos
        //Inserir Pessoa
        public bool InserePessoa(Pessoa p)
        {
            //Se a pessoa "p" já existe
            if (listaPessoas.Contains(p)) return false;
            //senão
            listaPessoas.Add(p);
            totalPessoas++;
            return true;
        }

        //Existe Pessoa?
    }


}
