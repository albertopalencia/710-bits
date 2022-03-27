// ***********************************************************************
// Assembly         : Domain
// Author           : alberto palencia
// Created          : 01-06-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-26-2022
// ***********************************************************************
// <copyright file="Factura.cs" company="Domain">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Domain.Entities
{
    /// <summary>
    /// Class Factura.
    /// </summary>
    public class Factura
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Factura"/> class.
        /// </summary>
        public Factura()
        {

        }


        /// <summary>
        /// Gets or sets the identifier factura.
        /// </summary>
        /// <value>The identifier factura.</value>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdFactura { get; set; }

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

        /// <summary>
        /// Gets or sets the factura productos.
        /// </summary>
        /// <value>The factura productos.</value>
        public virtual ICollection<FacturaProducto> FacturaProductos { get; set; }


        /// <summary>
        /// Adds the productos.
        /// </summary>
        /// <param name="productos">The productos.</param>
        public void AddProductos(params Productos[] productos)
        {
            var facturaProducto = new List<FacturaProducto>();
            productos.Aggregate(facturaProducto, (current, producto) =>
            {
                current.Add(new FacturaProducto(IdFactura, producto.IdProducto));
                return facturaProducto;
            });

            FacturaProductos = facturaProducto;

        }
    }
}
