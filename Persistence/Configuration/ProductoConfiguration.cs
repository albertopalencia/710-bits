// ***********************************************************************
// Assembly         : Persistence
// Author           : alberto palencia
// Created          : 01-06-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 01-06-2022
// ***********************************************************************
// <copyright file="EditorialConfiguration.cs" company="Persistence">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{ 
    public class ProductoConfiguration : IEntityTypeConfiguration<Productos>
    {
        /// <summary>
        /// Configures the entity of type <typeparamref name="TEntity" />.
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(EntityTypeBuilder<Productos> builder)
        {
            builder.HasKey(it => it.IdProducto);
            builder.ToTable("PRODUCTOS");
            builder.Property(it => it.IdProducto).HasColumnName("IdProducto".ToUpper());
            builder.Property(it => it.Producto).HasColumnName("Producto".ToUpper());

        }
    }
}
