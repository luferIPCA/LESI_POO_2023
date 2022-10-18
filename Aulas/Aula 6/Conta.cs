/*
*	<copyright file="Aula_6.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/17/2022 7:10:11 PM</date>
*	<description></description>
**/
using System;

namespace Aula_6
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/17/2022 7:10:11 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Conta
    {
        #region Attributes

        string iban;
        double saldo;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Conta()
        {
            iban = "";
            saldo = 5;
        }

        public Conta(string ib, double s)
        {
            iban = ib;
            saldo = s;
        }

        public Conta(double s, string ib )
        {
            iban = ib;
            saldo = s*2;
        }

        public Conta(double s)
        {
            iban = "";
            saldo = s;
        }
        #endregion

        #region Properties

        public string Iban
        {
            get { return iban; }
            set { iban = value; }
        }

        /// <summary>
        /// codPessoa==1 - vê tudo
        /// codPessoa!=1 - vê quase nada
        /// </summary>
        /// <param name="codPessoa"></param>
        /// <returns></returns>
        public double QualSaldo(int codPessoa)
        {
            if (codPessoa == 1)
            {
                return (saldo);
            }
            else
                return (saldo / 10);
        }

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Conta()
        {
        }
        #endregion

        #endregion
    }
}
