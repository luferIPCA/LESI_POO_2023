/*
*	<copyright file="ExerFolha3.API.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/17/2022 8:00:52 PM</date>
*	<description></description>
**/
using System;

namespace ExerFolha3
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/17/2022 8:00:52 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class AutomovelInvalidoException : ApplicationException
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public AutomovelInvalidoException() : base("Carro estranho!")
        {
         //   
        }

        public  AutomovelInvalidoException(string s): base(s)
        {

        }

        public AutomovelInvalidoException(string s, Exception e)
        {
            throw new Exception(e.Message + " - " + s);
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
        ~AutomovelInvalidoException()
        {
        }
        #endregion

        #endregion
    }
}
