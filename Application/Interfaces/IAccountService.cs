// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 03-23-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-24-2022
// ***********************************************************************
// <copyright file="IAccountService.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Threading.Tasks;
using Application.DTOs;
using Application.Wrappers;

namespace Application.Interfaces
{
    /// <summary>
    /// Interface IAccountService
    /// </summary>
    public interface IAccountService
    {
        /// <summary>
        /// Authenticates the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="ipAddress">The ip address.</param>
        /// <returns>Task&lt;Response&lt;AuthenticationResponseDto&gt;&gt;.</returns>
        Task<Response<AuthenticationResponseDto>> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
        /// <summary>
        /// Registers the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="origin">The origin.</param>
        /// <returns>Task&lt;Response&lt;System.String&gt;&gt;.</returns>
        Task<Response<string>> RegisterAsync(RegisterRequest request, string origin);
    }
}