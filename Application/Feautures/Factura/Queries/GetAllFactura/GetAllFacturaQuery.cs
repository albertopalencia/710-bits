// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 01-07-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-26-2022
// ***********************************************************************
// <copyright file="GetAllFacturaQuery.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Application.DTOs;
using Application.Interfaces;
using Application.Specifications;
using Application.Wrappers;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Feautures.Factura.Queries.GetAllFactura
{

    /// <summary>
    /// Class GetAllFacturaQuery.
    /// Implements the <see cref="MediatR.IRequest{Application.Wrappers.PagedResponse{System.Collections.Generic.List{Application.DTOs.FacturaDto}}}" />
    /// </summary>
    /// <seealso cref="MediatR.IRequest{Application.Wrappers.PagedResponse{System.Collections.Generic.List{Application.DTOs.FacturaDto}}}" />
    public class GetAllFacturaQuery : IRequest<PagedResponse<List<FacturaDto>>>
    {

        /// <summary>
        /// Gets or sets the page number.
        /// </summary>
        /// <value>The page number.</value>
        public int PageNumber { get; set; }
        /// <summary>
        /// Gets or sets the size of the page.
        /// </summary>
        /// <value>The size of the page.</value>
        public int PageSize { get; set; }



        /// <summary>
        /// Class GetAllFacturaQueryHandler.
        /// Implements the <see cref="MediatR.IRequestHandler{Application.Feautures.Book.Queries.GetAllFactura.GetAllFacturaQuery, Application.Wrappers.PagedResponse{System.Collections.Generic.List{Application.DTOs.FacturaDto}}}" />
        /// Implements the <see cref="MediatR.IRequestHandler{Application.Feautures.Factura.Queries.GetAllFactura.GetAllFacturaQuery, Application.Wrappers.PagedResponse{System.Collections.Generic.List{Application.DTOs.FacturaDto}}}" />
        /// </summary>
        /// <seealso cref="MediatR.IRequestHandler{Application.Feautures.Factura.Queries.GetAllFactura.GetAllFacturaQuery, Application.Wrappers.PagedResponse{System.Collections.Generic.List{Application.DTOs.FacturaDto}}}" />
        /// <seealso cref="MediatR.IRequestHandler{Application.Feautures.Book.Queries.GetAllFactura.GetAllFacturaQuery, Application.Wrappers.PagedResponse{System.Collections.Generic.List{Application.DTOs.FacturaDto}}}" />
        public class GetAllFacturaQueryHandler : IRequestHandler<GetAllFacturaQuery, PagedResponse<List<FacturaDto>>>
        {

            /// <summary>
            /// The repository
            /// </summary>
            private readonly IRepositoryAsync<Domain.Entities.Factura> _repository;
            /// <summary>
            /// The mapper
            /// </summary>
            private readonly IMapper _mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetAllFacturaQueryHandler" /> class.
            /// </summary>
            /// <param name="repository">The repository.</param>
            /// <param name="mapper">The mapper.</param>
            public GetAllFacturaQueryHandler(IRepositoryAsync<Domain.Entities.Factura> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }


            /// <summary>
            /// Handles a request
            /// </summary>
            /// <param name="request">The request</param>
            /// <param name="cancellationToken">Cancellation token</param>
            /// <returns>Response from the request</returns>
            /// <exception cref="System.NotImplementedException"></exception>
            public async Task<PagedResponse<List<FacturaDto>>> Handle(GetAllFacturaQuery request, CancellationToken cancellationToken)
            {
                var facturas = await _repository.ListAsync(new PagedFacturaSpecification(request.PageSize, request.PageNumber), cancellationToken);
                var facturasDto = _mapper.Map<List<FacturaDto>>(facturas).ToList();
                return new PagedResponse<List<FacturaDto>>(facturasDto, request.PageNumber, request.PageSize);
            }
        }
    }
}