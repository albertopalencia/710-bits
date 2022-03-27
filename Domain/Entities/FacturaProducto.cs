// ***********************************************************************
// Assembly         : Domain
// Author           : alberto palencia
// Created          : 01-06-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-26-2022
// ***********************************************************************
// <copyright file="FacturaProducto.cs" company="Domain">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Class FacturaProductos.
    /// </summary>
    public class FacturaProducto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacturaProducto"/> class.
        /// </summary>
        public FacturaProducto()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacturaProducto" /> class.
        /// </summary>
        /// <param name="factura">The author.</param>
        /// <param name="productos">The productos.</param>
        public FacturaProducto(Factura factura, Productos productos)
        {
            if (factura.IdFactura > 0)
                ProdutoId = productos.IdProducto;
            else
                Productos = productos;

            if (factura.IdFactura > 0)
                FacturaId = factura.IdFactura;
            else
                Factura = factura;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacturaProducto"/> class.
        /// </summary>
        /// <param name="facturaId">The factura identifier.</param>
        /// <param name="productoId">The producto identifier.</param>
        public FacturaProducto(int facturaId, int productoId)
        {
            FacturaId = facturaId;
            ProdutoId = productoId;
        }


        /// <summary>
        /// The factura identifier
        /// </summary>
        public int FacturaId;

        /// <summary>
        /// The produto identifier
        /// </summary>
        public int ProdutoId;

        /// <summary>
        /// Gets the author.
        /// </summary>
        /// <value>The author.</value>
        public virtual Productos Productos { get; }

        /// <summary>
        /// Gets the book.
        /// </summary>
        /// <value>The book.</value>
        [NotMapped]
        public virtual Factura Factura { get; private set; }
    }
}
