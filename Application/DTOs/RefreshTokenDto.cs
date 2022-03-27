// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 03-23-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-24-2022
// ***********************************************************************
// <copyright file="RefreshTokenDto.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace Application.DTOs
{
    /// <summary>
    /// Class RefreshTokenDto.
    /// </summary>
    public class RefreshTokenDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>The token.</value>
        public string Token { get; set; }
        /// <summary>
        /// Gets or sets the expires.
        /// </summary>
        /// <value>The expires.</value>
        public DateTime Expires { get; set; }
        /// <summary>
        /// Gets a value indicating whether this instance is expired.
        /// </summary>
        /// <value><c>true</c> if this instance is expired; otherwise, <c>false</c>.</value>
        public bool IsExpired => DateTime.Now >= Expires;
        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        /// <value>The created.</value>
        public DateTime Created { get; set; }
        /// <summary>
        /// Gets or sets the created by ip.
        /// </summary>
        /// <value>The created by ip.</value>
        public string CreatedByIp { get; set; }
        /// <summary>
        /// Gets or sets the revoked.
        /// </summary>
        /// <value>The revoked.</value>
        public DateTime? Revoked { get; set; }

        /// <summary>
        /// Gets or sets the revoked by ip.
        /// </summary>
        /// <value>The revoked by ip.</value>
        public string RevokedByIp { get; set; }
        /// <summary>
        /// Gets or sets the replaced by token.
        /// </summary>
        /// <value>The replaced by token.</value>
        public string ReplacedByToken { get; set; }
        /// <summary>
        /// Gets a value indicating whether this instance is active.
        /// </summary>
        /// <value><c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
        public bool IsActive => Revoked is null && !IsExpired;
    }
}