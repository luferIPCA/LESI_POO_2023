/**
 * Resolução parcial do Teste de POO - 2022-2023
 * Data
 * email
 * lufer
 * */
using System;

namespace Teste_2022_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa e1 = new Empresa("IPCA");

            Maquina m1 = new Maquina();
            m1.estado = Estado.OPERACIONAL;
            m1.tarefa = Tarefa.CORTAR;
            m1.cod = 1;

            Maquina m2 = new Maquina();
            m2.estado = Estado.OCUPADA;
            m2.tarefa = Tarefa.SOLDAR;
            m2.cod = 2;

            LinhaProducao l1 = new LinhaProducao();
            l1.AddMaquina(m1);

            e1.CriaLinhaProducao(l1);
            e1.AddMaquinaLinhaProducao(l1.codLinhaProducao, m2);

        }
    }
}
