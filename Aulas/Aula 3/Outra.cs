/*
*	<copyright file="Aula_3.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/3/2022 8:15:53 PM</date>
*	<description></description>
**/
using System;

namespace Aula_3
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/3/2022 8:15:53 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Outra
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Outra()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public static void MostraArrayII(string[] n)
        {
            foreach (string s in n)
            {
                Console.WriteLine(s);
            }
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Outra()
        {
        }
        #endregion

        #endregion
    }
}
