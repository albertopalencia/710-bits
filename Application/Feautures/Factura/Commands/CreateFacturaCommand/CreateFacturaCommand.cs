// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 01-07-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-26-2022
// ***********************************************************************
// <copyright file="CreateFacturaCommand.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Wrappers;
using MediatR;

namespace Application.Feautures.Factura.Commands.CreateFacturaCommand
{
    /// <summary>
    /// Class CreateFacturaCommand.
    /// Implements the <see cref="MediatR.IRequest{Response{int}}" />
    /// Implements the <see cref="MediatR.IRequest{Application.Wrappers.Response{System.Int32}}" />
    /// </summary>
    /// <seealso cref="MediatR.IRequest{Application.Wrappers.Response{System.Int32}}" />
    /// <seealso cref="MediatR.IRequest{Response{int}}" />
    public class CreateFacturaCommand : IRequest<Response<int>>
    {

        /// <summary>
        /// Class CreateFacturaCommandHandler.
        /// Implements the <see cref="MediatR.IRequestHandler{Application.Feautures.Factura.Commands.CreateFacturaCommand.CreateFacturaCommand, Application.Wrappers.Response{System.Int32}}" />
        /// </summary>
        /// <seealso cref="MediatR.IRequestHandler{Application.Feautures.Factura.Commands.CreateFacturaCommand.CreateFacturaCommand, Application.Wrappers.Response{System.Int32}}" />
        public class CreateFacturaCommandHandler : IRequestHandler<CreateFacturaCommand, Response<int>>
        {
            /// <summary>
            /// The repository
            /// </summary>
            private readonly IRepositoryAsync<Domain.Entities.Factura> _repository;

            /// <summary>
            /// Initializes a new instance of the <see cref="CreateFacturaCommandHandler" /> class.
            /// </summary>
            /// <param name="repository">The repository.</param>
            public CreateFacturaCommandHandler(IRepositoryAsync<Domain.Entities.Factura> repository)
            {
                _repository = repository;
            }

            /// <summary>
            /// Handles a request
            /// </summary>
            /// <param name="request">The request</param>
            /// <param name="cancellationToken">Cancellation token</param>
            /// <returns>Response from the request</returns>
            public async Task<Response<int>> Handle(CreateFacturaCommand request, CancellationToken cancellationToken)
            {
                var factura = new Domain.Entities.Factura();
                await _repository.AddAsync(factura, cancellationToken);
                return new Response<int>(factura.IdFactura);
            }
        }
    }
}