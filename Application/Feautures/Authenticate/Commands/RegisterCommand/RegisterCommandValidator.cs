// ***********************************************************************
// Assembly         : Application
// Author           : alberto palencia
// Created          : 03-23-2022
//
// Last Modified By : alberto palencia
// Last Modified On : 03-24-2022
// ***********************************************************************
// <copyright file="RegisterCommandValidator.cs" company="Application">
//     Copyright (c) everis. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using FluentValidation;

namespace Application.Feautures.Authenticate.Commands.RegisterCommand
{
    /// <summary>
    /// Class RegisterCommandValidator.
    /// Implements the <see cref="FluentValidation.AbstractValidator{Application.Feautures.Authenticate.Commands.RegisterCommand.RegisterCommand}" />
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator{Application.Feautures.Authenticate.Commands.RegisterCommand.RegisterCommand}" />
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterCommandValidator" /> class.
        /// </summary>
        public RegisterCommandValidator()
        {
            RuleFor(it => it.Nombre)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(it => it.Apellido)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(it => it.Email)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
                .EmailAddress().WithMessage("{PropertyName} debe ser una direccion de email valida")
                .MaximumLength(100).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(it => it.UserName)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
                .MaximumLength(10).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(it => it.Password)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
                .MaximumLength(15).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(it => it.ConfirmPassword)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
                .MaximumLength(15).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres")
                .Equal(p => p.Password).WithMessage("{PropertyName} debe ser igual a password");
        }
    }
}