/*
*	<copyright file="Aula_8.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/26/2022 9:52:32 PM</date>
*	<description></description>
**/
using System;

namespace Aula_8
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/26/2022 9:52:32 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Carro : Veiculo
    {
        #region Attributes

        string marca;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Carro()
        {
            marca = "";
        }

        public Carro(string s)
        {
            marca = s;
        }
        #endregion

        #region Properties

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int Ano
        {
            get;
            set;
        }
        #endregion

        #region Overrides

        public override string GetVeiculoDetais()
        {
            return "Carro: " + marca + base.GetVeiculoDetais();
        }

        #endregion

        #region OtherMethods

        public string GetCarroDetails()
        {
            return ("Marca:" + marca + " Ano:" + base.Ano.ToString());
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Carro()
        {
        }
        #endregion

        #endregion
    }
}
