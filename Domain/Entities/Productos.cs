// ***********************************************************************
// Assembly         : Domain
// Author           : alberto palencia
// Created          : 01-06-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-26-2022
// ***********************************************************************
// <copyright file="Productos.cs" company="Domain">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Domain.Entities
{
    /// <summary>
    /// Class Productos.
    /// </summary>
    public class Productos
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Producto" /> class.
        /// </summary>
        public Productos()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Producto" /> class.
        /// </summary>
        /// <param name="producto">The producto.</param>
        /// <param name="id">The identifier.</param>
        public Productos(string producto, int? id = null)
        {
            Producto = producto;
            IdProducto = id ?? 0;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int IdProducto { get; set; }

        /// <summary>
        /// Gets the productos.
        /// </summary>
        /// <value>The productos.</value>
        public string Producto { get; set; }
         
    }
}
