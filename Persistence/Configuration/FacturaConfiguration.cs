// ***********************************************************************
// Assembly         : Persistence
// Author           : alberto palencia
// Created          : 01-06-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 01-06-2022
// ***********************************************************************
// <copyright file="FacturaConfiguration.cs" company="Persistence">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Persistence.Configuration
{
    /// <summary>
    /// Class FacturaConfiguration.
    /// Implements the <see cref="Microsoft.EntityFrameworkCore.IEntityTypeConfiguration{Factura}" />
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.IEntityTypeConfiguration{Factura}" />
    public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
    {
        /// <summary>
        /// Configures the entity of type <typeparamref name="TEntity" />.
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.ToTable("FACTURAS".ToUpper());
            builder.HasNoKey();
            builder.Property(it => it.IdFactura).HasColumnName("IDFACTURA".ToUpper());
            builder.Property(it => it.NumeroFactura).HasColumnName("NUMEROFACTURA".ToUpper());
            builder.Property(it => it.Fecha).HasColumnName("FECHA".ToUpper());
            builder.Property(it => it.TipoDePago).HasColumnName("TIPODEPAGO".ToUpper());
            builder.Property(it => it.DocumentoCliente).HasColumnName("DOCUMENTOCLIENTE".ToUpper());
            builder.Property(it => it.NombreCliente).HasColumnName("NOMBRECLIENTE".ToUpper());
            builder.Property(it => it.Descuento).HasColumnName("DESCUENTO".ToUpper());
            builder.Property(it => it.SubTotal).HasColumnName("SUBTOTAL".ToUpper());
            builder.Property(it => it.Iva).HasColumnName("IVA".ToUpper());
            builder.Property(it => it.TotalDescuento).HasColumnName("TOTALDESCUENTO".ToUpper());
            builder.Property(it => it.TotalImpuesto).HasColumnName("TOTALIMPUESTO".ToUpper());
            builder.Property(it => it.Total).HasColumnName("TOTAL".ToUpper());

        }
    }
}
