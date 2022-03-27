// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 03-23-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-24-2022
// ***********************************************************************
// <copyright file="AuthenticateCommand.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Threading;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Application.Wrappers;
using MediatR;

namespace Application.Feautures.Authenticate.Commands.AuthenticateCommand
{
    /// <summary>
    /// Class AuthenticateCommand.
    /// Implements the <see cref="MediatR.IRequest{Application.Wrappers.Response{Application.DTOs.AuthenticationResponseDto}}" />
    /// </summary>
    /// <seealso cref="MediatR.IRequest{Application.Wrappers.Response{Application.DTOs.AuthenticationResponseDto}}" />
    public class AuthenticateCommand : IRequest<Response<AuthenticationResponseDto>>
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the ip address.
        /// </summary>
        /// <value>The ip address.</value>
        public string IpAddress { get; set; }

        /// <summary>
        /// Class AuthenticateCommandHandler.
        /// Implements the <see cref="MediatR.IRequestHandler{Application.Feautures.Authenticate.Commands.AuthenticateCommand.AuthenticateCommand, Application.Wrappers.Response{Application.DTOs.AuthenticationResponseDto}}" />
        /// </summary>
        /// <seealso cref="MediatR.IRequestHandler{Application.Feautures.Authenticate.Commands.AuthenticateCommand.AuthenticateCommand, Application.Wrappers.Response{Application.DTOs.AuthenticationResponseDto}}" />
        public class  AuthenticateCommandHandler: IRequestHandler<AuthenticateCommand, Response<AuthenticationResponseDto>>
        {
            /// <summary>
            /// The account service
            /// </summary>
            private readonly IAccountService _accountService;

            /// <summary>
            /// Initializes a new instance of the <see cref="AuthenticateCommandHandler" /> class.
            /// </summary>
            /// <param name="accountService">The account service.</param>
            public AuthenticateCommandHandler(IAccountService accountService)
            {
                _accountService = accountService;
            }

            /// <summary>
            /// Handles the specified request.
            /// </summary>
            /// <param name="request">The request.</param>
            /// <param name="cancellationToken">The cancellation token.</param>
            /// <returns>Task&lt;Response&lt;AuthenticationResponseDto&gt;&gt;.</returns>
            public async Task<Response<AuthenticationResponseDto>> Handle(AuthenticateCommand request, CancellationToken cancellationToken)
            {
                return await _accountService.AuthenticateAsync(new AuthenticationRequest
                {
                    Email = request.Email,
                    Password = request.Password
                }, request.IpAddress);
            }
        }
    }
}