/*
*	<copyright file="Aula_8.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/26/2022 9:33:22 PM</date>
*	<description></description>
**/
using System;

namespace Aula_8
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/26/2022 9:33:22 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Veiculo
    {
        #region Attributes
        
        int ano;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Veiculo()
        {
            ano = 2022;
        }

        public Veiculo(int x)
        {
            ano = x;
        }

        #endregion

        #region Properties

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        #endregion

        #region Overrides
        //public override string ToString()
        //{
        //    return "ANO:" + (ano / 2).ToString();
        //}
        #endregion

        #region OtherMethods

        public virtual string GetVeiculoDetais()
        {
            return "Ano: " + ano.ToString();
        }


        public static void FazCoisas(IVeiculo x)
        {
            int a = x.Ano();
            string s = x.MostraDetalhes();
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Veiculo()
        {
        }
        #endregion

        #endregion
    }



}
