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
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/7/2022 6:23:48 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Veiculos
    {
        #region Attributes
        static ArrayList all;
        static int tot;
        #endregion

        #region Methods

        #region Constructors

        static Veiculos()
        {
            all = new ArrayList();
            tot = 0;
        }
        /// <summary>
        /// The default Constructor.
        /// </summary>
        public static bool InsVeiculo(Automovel a)
        {
            if (!all.Contains(a))
            {
                all.Add(a);
                tot++;
                return true;
            }
            return false;
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Veiculos()
        {
        }
        #endregion

        #endregion
    }
}
