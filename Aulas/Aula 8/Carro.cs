/*
*	<copyright file="Aula_8.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/26/2022 9:52:32 PM</date>
*	<description>
*	https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types?f1url=%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(byte_CSharpKeyword)%3Bk(DevLang-csharp)%26rd%3Dtrue
*	</description>
**/
using System;

enum COMB
{
    Gasolina=1,
    GAZO=2,
    GAS=3,
    ELE=4
}

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
        COMB combustivel;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Carro()
        {
            marca = "";
            combustivel = COMB.ELE;
        }

        public Carro(string s)
        {
            marca = s;
        }

        public Carro (string marca, int a) : base(a)
        {
            this.marca = marca;
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
