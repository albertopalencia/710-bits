// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 03-23-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-26-2022
// ***********************************************************************
// <copyright file="ProductoDto.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Application.DTOs
{
    /// <summary>
    /// Class ProductoDto.
    /// </summary>
    public class ProductoDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int IdProducto { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Producto { get; set; }
    }
}