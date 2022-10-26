/*
*	<copyright file="Aula_7.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/24/2022 7:18:02 PM</date>
*	<description></description>
**/
using System;

namespace Aula_7
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/24/2022 7:18:02 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Carro
    {
        #region Attributes
        int ano;

        static int totCarros = 0;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Carro()
        {
            ano = DateTime.Today.Year;
            totCarros++;
        }

        public Carro(int ano)
        {
            this.ano = ano;
            totCarros++;
        }

        #endregion

        #region Properties

        public int Ano
        {
            get { return ano; }
            set { if (value > 0) ano = value; }
        }

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        //public int TotCarros()
        //{
        //    return totCarros;
        //}
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Carro()
        {

        }
        #endregion

        #region METODOS CLASSE

        public static int GetTotCarros()
        {
            //if (oauth)
            return totCarros;
        }

        public static int GetTotCarrosProp
        {
            get { return totCarros; }
        }
        #endregion

        #endregion
    }
}
