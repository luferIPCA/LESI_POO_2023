using System;

namespace ExercSlides
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca b = new Biblioteca("IPCA");

            //Versão1
            Utilizador1 u1 = new Utilizador1(TIPOUTILIZADOR.ALUNO);
            Utilizador1 u2 = new Utilizador1(TIPOUTILIZADOR.PROF);

            //Versão 2
            Utilizador u3 = new Utilizador();
            Utilizador u4 = new Utilizador();

            Obra o1 = new Obra(TIPOOBRA.cientificos);
            o1.Titulo = "Os Lusíadas";

            b.RegistaUtilizador(u3);
            b.RegistaUtilizador(u4);

            Autor a1 = new Autor();
            a1.Nome = "Camões";
            o1.InsereAutorObra(a1);

            b.RegistaObra(o1);
            b.MostraObras();

            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
