/*
*	<copyright file="Aula_8.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/27/2022 6:16:13 PM</date>
*	<description></description>
**/
using System;

namespace Aula_8
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/27/2022 6:16:13 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class QuaseCarro
    {
        #region Attributes

        short portas;

        #endregion

        #region Methods


        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public virtual int Soma (int x, int y)
        {
            return x + y;
        }
        public abstract string InforCarro();

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~QuaseCarro()
        {
        }
        #endregion

        #endregion
    }

    public class CarroASerio : QuaseCarro
    {

        public override string InforCarro()
        {
            return "";
        }

        public override int Soma(int x, int y)
        {
            return (x+y * 2);
        }

    }

    public class CarroMaisSerio : QuaseCarro
    {

        public override string InforCarro()
        {
            return "Viva o Benfica";
        }

        public override int Soma(int x, int y)
        {
            return (x + y * 2);
        }

    }
}
