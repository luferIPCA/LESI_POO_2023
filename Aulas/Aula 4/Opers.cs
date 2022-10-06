//by lufer

namespace Aula_4
{
    /// <summary>
    /// 
    /// </summary>
    class Opers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valores"></param>
        /// <returns></returns>
        public static double CalculaMedia(int[] valores)
        {
            int s = 0;
            double av;

            foreach(int x in valores)
            {  
                s += x; //s = s + x
            }
            av = (double)s / valores.Length;    
            return av;
        }


        public static int Soma (int x, int y)
        {
            return (x + y);
        }
    }
}
