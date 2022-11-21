/*
*	<copyright file="Aula_9___Exceptions.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/14/2022 12:17:02 PM</date>
*	<description></description>
**/

using System;

namespace Aula_9___Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int x = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                
            }
            catch (Exception e)
            {

            }
        }
    }
}
