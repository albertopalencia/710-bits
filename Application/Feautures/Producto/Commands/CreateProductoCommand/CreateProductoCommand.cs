// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 01-07-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 01-13-2022
// ***********************************************************************
// <copyright file="CreateEditorialCommand.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Threading;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Interfaces;
using Application.Wrappers;
using MediatR;

namespace Application.Feautures.Producto.Commands.CreateProductoCommand
{
    /// <summary>
    /// Class CreateFacturaCommand.
    /// Implements the <see cref="MediatR.IRequest{Response{int}}" />
    /// Implements the <see cref="MediatR.IRequest{Application.Wrappers.Response{System.Int32}}" />
    /// </summary>
    /// <seealso cref="MediatR.IRequest{Application.Wrappers.Response{System.Int32}}" />
    /// <seealso cref="MediatR.IRequest{Response{int}}" />
    public class CreateProductoCommand: IRequest<Response<int>>
    {
        /// <summary>
        /// Gets or sets the isbn.
        /// </summary>
        /// <value>The isbn.</value>
        public string Name { get; set; }


        public class CreateEditorialCommandHandler : IRequestHandler<CreateProductoCommand, Response<int>>
        {
            /// <summary>
            /// The repository
            /// </summary>
            private readonly IRepositoryAsync<Domain.Entities.Productos> _repository;


            /// <summary>
            /// Initializes a new instance of the <see cref="CreateEditorialCommandHandler"/> class.
            /// </summary>
            /// <param name="repository">The repository.</param>
            public CreateEditorialCommandHandler(IRepositoryAsync<Domain.Entities.Productos> repository)
            {
                _repository = repository;
            }

            /// <summary>
            /// Handles a request
            /// </summary>
            /// <param name="request">The request</param>
            /// <param name="cancellationToken">Cancellation token</param>
            /// <returns>Response from the request</returns>
            /// <exception cref="ApiException">El codigo {request.Isbn} ya esta siendo utilizado</exception>
            public async Task<Response<int>> Handle(CreateProductoCommand request, CancellationToken cancellationToken)
            {
                var producto = new Domain.Entities.Productos(request.Name);
                await _repository.AddAsync(producto, cancellationToken);
                return new Response<int>(producto.IdProducto);
            }
        }
    }
}