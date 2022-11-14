using System;
using System.Collections;

namespace ExerFolha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovel a1 = new Automovel("12-12-12", 1, 2022,COMB.GAZ);
            Console.WriteLine("Custo Automovel a1:" + a1.Custo().ToString());

            //AutomovelLuxo al = new AutomovelLuxo();
            AutomovelLuxo a2 = new AutomovelLuxo(true, true, true);
            a2.SetMatricula("NBB");
            AutomovelLuxo a3 = new AutomovelLuxo(true, true, false, 2023, "AA-00-11", 2,COMB.ELE);
            AutomovelLuxo a4 = new AutomovelLuxo(true, true, false, 2023, "AA-11-23", 2, COMB.ELE);
            double tot = a3.Custo();

            if (a3.Ano == a4.Ano)
            {

            }
                if (a3.Compare(a4)==0)
            {

            }
            a3.CompareTo(a4);

            //String.Compare("Ok","Ok1")

            Garagem g1 = new Garagem();
            Garagem g2 = new Garagem();

            a3.EstacionaCarro();
            a1.EstacionaCarro();

            Console.WriteLine("\nCarros na Garagem\n");
            ArrayList carr = Garagem.Estacionados();
            foreach(Automovel a in carr)
            {
                Console.Write(a.ToString());
            }
            //or
            Console.WriteLine("\nCarros na Garagem\n");
            Garagem.ShowAll();

            Console.WriteLine("\nCarros na Garagem Ordenados\n");
            carr.Sort();
            Garagem.ShowAll(carr);

        }
    }
}
