/*
*	<copyright file="ExerFolha3.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/7/2022 6:23:48 PM</date>
*	<description></description>
**/


using System;
using System.Collections;

namespace ExerFolha3
{
    /// <summary>
    /// 
    /// </summary>
    class Garagem
    {
        //static Automovel[] carros;

        static ArrayList carros;
        static int totCarros;

        /// <summary>
        /// Construtor static
        /// </summary>
        static Garagem()
        {
            carros = new ArrayList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool EstacionaCarro(Automovel a)
        {
            if (!carros.Contains(a))
            {
                carros.Add(a);
                totCarros++;
                return true;
            }
            return false;
        }

        public static ArrayList Estacionados()
        {
            ArrayList aux = new ArrayList();
            aux = (ArrayList)carros.Clone();
            return aux;
        }

        /// <summary>
        /// Property
        /// </summary>
        public static ArrayList Carros
        {
            get { return ((ArrayList)carros.Clone()); }
        }


        public static void ShowAll()
        {
            foreach (object o in carros)
            {
                //Console.WriteLine(o.GetType());
                /*
                 if (o.GetType() == typeof(int))                                 //int
                {
                    Console.WriteLine("Int: " + o.ToString()); continue;
                }
                if (o.GetType() == typeof(string))                              //string
                {
                    Console.WriteLine("Str: " + o.ToString()); continue;
                }
                if (o.GetType() == typeof(string[]))                            //array
                {
                    Console.WriteLine("Str[]: " + o.ToString()); continue;
                }
                */
                if (o.GetType() == typeof(Automovel) || o.GetType() == typeof(AutomovelLuxo))                              //struct or classe
                {
                    Automovel aux = (Automovel)o;

                    Console.Write(aux.ToString()); continue;
                }
            }
        }

        public static void ShowAll(ArrayList carros)
        {
            foreach (object o in carros)
            {
                //Console.WriteLine(o.GetType());
                /*
                 if (o.GetType() == typeof(int))                                 //int
                {
                    Console.WriteLine("Int: " + o.ToString()); continue;
                }
                if (o.GetType() == typeof(string))                              //string
                {
                    Console.WriteLine("Str: " + o.ToString()); continue;
                }
                if (o.GetType() == typeof(string[]))                            //array
                {
                    Console.WriteLine("Str[]: " + o.ToString()); continue;
                }
                */
                if (o.GetType() == typeof(Automovel) || o.GetType() == typeof(AutomovelLuxo))                              //struct or classe
                {
                    Automovel aux = (Automovel)o;

                    Console.Write(aux.ToString()); continue;
                }
            }
        }
    }
}
