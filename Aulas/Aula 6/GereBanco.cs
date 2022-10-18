/*
*	<copyright file="Aula_6.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/17/2022 7:15:48 PM</date>
*	<description></description>
**/
using System;

namespace Aula_6
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/17/2022 7:15:48 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class GereBanco
    {
        static void Main()
        {
            Conta x;

            x = new Conta();

            x.Iban = "0001";
            Console.WriteLine("IBAN: {0}",x.Iban);
            Console.WriteLine("Saldo: " + x.QualSaldo(1).ToString());
            Console.WriteLine("Saldo: " + x.QualSaldo(7).ToString());

            Conta y = new Conta("1111", 100.0);

            Conta z = new Conta(150.0, "1111");
        }

    }
}
