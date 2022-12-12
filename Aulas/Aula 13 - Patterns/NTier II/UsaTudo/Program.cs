using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsaTudo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BL.Rules.InsereValorBD(120);

            BO.Pessoa p = new BO.Pessoa();
            p.idade = 12;
            p.nome = "ola";

            
            Console.WriteLine("Existe? " + BL.Rules.ExisteValBD(120));
            bool aux = BL.Rules.InserePessoa(p);

        }
    }
}
