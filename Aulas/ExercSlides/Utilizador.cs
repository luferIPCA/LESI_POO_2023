/*
*	<copyright file="ExercSlides.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/31/2022 7:43:36 PM</date>
*	<description>
*	Versão1: Apenas classe Utilizador
*	Versão2: Criar sub-classes Aluno, Professor e Fucnionário
*	</description>
**/
using System;

public enum TIPOUTILIZADOR
{
    ALUNO,
    PROF,
    FUNC
}

namespace ExercSlides
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/31/2022 7:43:36 PM
    /// </summary>
    /// <remarks>VERSÂO 1</remarks>
    /// <example></example>
    public class Utilizador1
    {
        #region Attributes

        TIPOUTILIZADOR tipo;

        #endregion

        
        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Utilizador1()
        {
            tipo = TIPOUTILIZADOR.PROF;
        }

        public Utilizador1(TIPOUTILIZADOR t)
        {
            tipo = t;
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
        ~Utilizador1()
        {
        }
        #endregion

        #endregion
    }


    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/31/2022 7:43:36 PM
    /// </summary>
    /// <remarks>VERSÂO II</remarks>
    /// <example></example>
    public class Utilizador
    {
        #region Attributes

        string nome;
        int ano;

        #endregion


        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Utilizador()
        {
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
        ~Utilizador()
        {
        }
        #endregion

        #endregion
    }

    public class Aluno: Utilizador
    {
        int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
    }

    public class Professor: Utilizador
    {
        string area;
    }


    public class Funcionario : Utilizador
    {
        string departamento;
    }
}
