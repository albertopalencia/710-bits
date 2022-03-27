// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 03-23-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-24-2022
// ***********************************************************************
// <copyright file="AuthenticationResponseDto.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Text.Json.Serialization;
 

namespace Application.DTOs
{
    /// <summary>
    /// Class AuthenticationResponseDto.
    /// </summary>
    public class AuthenticationResponseDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the roles.
        /// </summary>
        /// <value>The roles.</value>
        public List<string> Roles { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is verified.
        /// </summary>
        /// <value><c>true</c> if this instance is verified; otherwise, <c>false</c>.</value>
        public bool IsVerified { get; set; }
        /// <summary>
        /// Gets or sets the jw token.
        /// </summary>
        /// <value>The jw token.</value>
        public string JwToken { get; set; }

        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        /// <value>The refresh token.</value>
        [JsonIgnore]
        public string RefreshToken { get; set; }
    }
}