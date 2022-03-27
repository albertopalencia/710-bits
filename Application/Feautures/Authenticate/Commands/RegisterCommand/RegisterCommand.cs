// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 03-23-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-24-2022
// ***********************************************************************
// <copyright file="RegisterCommand.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Application.DTOs;
using Application.Interfaces;
using Application.Wrappers;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Feautures.Authenticate.Commands.RegisterCommand
{
    /// <summary>
    /// Class RegisterCommand.
    /// Implements the <see cref="MediatR.IRequest{Application.Wrappers.Response{System.String}}" />
    /// </summary>
    /// <seealso cref="MediatR.IRequest{Application.Wrappers.Response{System.String}}" />
    public class RegisterCommand : IRequest<Response<string>>
    {
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        public string Nombre { get; set; }
        /// <summary>
        /// Gets or sets the apellido.
        /// </summary>
        /// <value>The apellido.</value>
        public string Apellido { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName { get; set; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the confirm password.
        /// </summary>
        /// <value>The confirm password.</value>
        public string ConfirmPassword { get; set; }
        /// <summary>
        /// Gets or sets the origin.
        /// </summary>
        /// <value>The origin.</value>
        public string Origin { get; set; }

        /// <summary>
        /// Class RegisterCommandHandler.
        /// Implements the <see cref="MediatR.IRequestHandler{Application.Feautures.Authenticate.Commands.RegisterCommand.RegisterCommand, Application.Wrappers.Response{System.String}}" />
        /// </summary>
        /// <seealso cref="MediatR.IRequestHandler{Application.Feautures.Authenticate.Commands.RegisterCommand.RegisterCommand, Application.Wrappers.Response{System.String}}" />
        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Response<string>>
        {
            /// <summary>
            /// The account service
            /// </summary>
            private readonly IAccountService _accountService;

            /// <summary>
            /// Initializes a new instance of the <see cref="RegisterCommandHandler" /> class.
            /// </summary>
            /// <param name="accountService">The account service.</param>
            public RegisterCommandHandler(IAccountService accountService)
            {
                _accountService = accountService;
            }

            /// <summary>
            /// Handles the specified request.
            /// </summary>
            /// <param name="request">The request.</param>
            /// <param name="cancellationToken">The cancellation token.</param>
            /// <returns>Task&lt;Response&lt;System.String&gt;&gt;.</returns>
            public async Task<Response<string>> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                return await _accountService.RegisterAsync(new RegisterRequest
                {
                    Email = request.Email,
                    UserName = request.UserName,
                    Password = request.Password,
                    ConfirmPassword = request.ConfirmPassword,
                    Nombre = request.Nombre,
                    Apellido = request.Apellido
                }, request.Origin);
            }
        }
    }
}