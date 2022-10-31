using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8
{
    public interface IVeiculo
    {
        int Ano();
        string MostraDetalhes();
    }

    public class Nova
    {
        public int Ano1()
        {
            return DateTime.Today.Year;
        }

        public string MostraDetalhes()
        {
            return "";
        }
    }
}
