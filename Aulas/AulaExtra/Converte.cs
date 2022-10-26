
//by lufer
//Folha 2, Exercicio 1

using System;

namespace AulaExtra
{
    class Converte
    {
        int x;
        public Converte()
        {
            x = 0;
        }

        public Converte(int x)
        {
            this.x = 2 * x;
        }

        public double C2F(double c)
        {
            return (1); //Depois coloca-se a forma correta!!!
        }

        void MostraValores(int inicio, int fim)
        { 
            //b Mostra de 100 a -10
            for (int i = inicio; i >= -10; i--)
            {
                Console.Write("{0} graus C = {1} F\n", i.ToString(), C2F(i).ToString());
            }
        }
    }

    class Veiculo
    {
        int ano;
    }

    public abstract class Carro : Veiculo
    {
        string marca;
        public abstract string GetMarca();
        public virtual string GetMarcaUpperCase()
        {
            return marca.ToUpper();
        }
    }

    public class CarroLigeiro: Carro
    {
        public override string GetMarca()
        {
            throw new NotImplementedException();
        }

        public override string GetMarcaUpperCase()
        {
            return base.GetMarcaUpperCase().ToLower();
        }
    }
}
