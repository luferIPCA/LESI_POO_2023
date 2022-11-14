/*
*	<copyright file="ExerFolha3.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/7/2022 6:55:50 PM</date>
*	<description></description>
**/
using System;

namespace ExerFolha3
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/7/2022 6:55:50 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class AutomovelLuxo : Automovel
    {
        #region Attributes
        bool ve;
        bool ac;
        bool da;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public AutomovelLuxo()
        {
            da = false;
            ve = false;
            ac = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ac"></param>
        /// <param name="ve"></param>
        /// <param name="da"></param>
        /// <param name="ano"></param>
        /// <param name="mat"></param>
        /// <param name="comb"></param>
        /// <param name="c"></param>
        public AutomovelLuxo(bool ac, bool ve, bool da, short ano, string mat, byte comb, COMB c) :base (mat,comb,ano,c) 
        {
            this.da = da;
            this.ve = ve;
            this.ac = ac;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ac"></param>
        /// <param name="ve"></param>
        /// <param name="da"></param>
        public AutomovelLuxo(bool ac, bool ve, bool da)
        {
            this.da = da;
            this.ve = ve;
            this.ac = ac;
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public bool SetMatricula(string mat)
        {
            base.Matricula = mat;
            return true;
        }

        public override double Custo()
        {
            int tot = 0;
            //
            if (ac == true) tot += 2000;
            if (ve == true) tot += 800;
            if (da == true) tot += 1500;

            return (base.Custo()+tot);
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~AutomovelLuxo()
        {
        }
        #endregion

        #endregion
    }
}
