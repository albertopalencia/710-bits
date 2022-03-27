// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 03-23-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-25-2022
// ***********************************************************************
// <copyright file="FacturaDto.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace Application.DTOs
{
    /// <summary>
    /// Class FacturaDto.
    /// </summary>
    public class FacturaDto
    {

        /// <summary>
        /// Gets the editorial identifier.
        /// </summary>
        /// <value>The editorial identifier.</value>
        public string NumeroFactura { get; set; }

        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>The title.</value>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Gets the sypnosis.
        /// </summary>
        /// <value>The sypnosis.</value>
        public string TipoDePago { get; set; }

        /// <summary>
        /// Gets the number pages.
        /// </summary>
        /// <value>The number pages.</value>
        public string DocumentoCliente { get; set; }

        /// <summary>
        /// Gets or sets the nombre cliente.
        /// </summary>
        /// <value>The nombre cliente.</value>
        public string NombreCliente { get; set; }

        /// <summary>
        /// Gets or sets the sub total.
        /// </summary>
        /// <value>The sub total.</value>
        public decimal SubTotal { get; set; }
        /// <summary>
        /// Gets or sets the descuento.
        /// </summary>
        /// <value>The descuento.</value>
        public int Descuento { get; set; }

        /// <summary>
        /// Gets or sets the iva.
        /// </summary>
        /// <value>The iva.</value>
        public int Iva { get; set; }

        /// <summary>
        /// Gets or sets the total descuento.
        /// </summary>
        /// <value>The total descuento.</value>
        public int TotalDescuento { get; set; }

        /// <summary>
        /// Gets or sets the total impuesto.
        /// </summary>
        /// <value>The total impuesto.</value>
        public int TotalImpuesto { get; set; }
        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        public decimal Total { get; set; }


    }
}