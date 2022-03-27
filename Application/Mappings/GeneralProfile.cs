// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 01-07-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-26-2022
// ***********************************************************************
// <copyright file="GeneralProfile.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Application.DTOs;
using Application.Feautures.Factura.Commands.CreateFacturaCommand;
using Application.Feautures.Producto.Commands.CreateProductoCommand;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    /// <summary>
    /// Class GeneralProfile.
    /// Implements the <see cref="AutoMapper.Profile" />
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class GeneralProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralProfile" /> class.
        /// </summary>
        public GeneralProfile()
        {
            #region Dtos 

            CreateMap<Factura, FacturaDto>().ReverseMap();

            CreateMap<Productos, ProductoDto>().ReverseMap();
            #endregion

            #region Commands

            CreateMap<CreateProductoCommand, Productos>();

            CreateMap<CreateFacturaCommand, Factura>();

            #endregion
        }
    }
}