using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.ClientEntity;
using XAct;

namespace TicketSale.Application.Validators
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator() 
        {
            RuleFor(x => x.Email)
                    .NotEmpty().WithName("Email").WithMessage("O campo email não pode ser vazio.")
                    .NotNull().WithName("Email").WithMessage("O campo email não pode ser nulo.")
                    .EmailAddress().WithName("Email").WithMessage("O campo email esta inválido.");

            RuleFor(x => x.Password)
                    .NotEmpty().WithName("Senha").WithMessage("O campo Senha não pode ser vazia.")
                    .NotNull().WithName("Senha").WithMessage("O campo Senha não pode ser nulo")
                    .Matches(@"^(?=.*[A-Z])(?=.*[!@#$&*()])(?=.*[a-z].*[a-z]).+$").WithName("Senha").WithMessage("O campo Senha não atendeu aos requisitos.")
                    .MinimumLength(4).WithName("Senha").WithMessage("O campo Senha deve conter no mínimo 4 caracteres.");

            RuleFor(x => x.AdressInfo)
                .NotEmpty().WithName("Endereço").WithMessage("O campo Endereço não pode ser vazio.")
                .NotNull().WithName("Endereço").WithMessage("O campo Endereço não pode ser nulo");

            RuleFor(x => x.CityId)
                .NotEmpty().WithName("Cidade").WithMessage("O campo Cidade não pode ser vazio.")
                .NotNull().WithName("Cidade").WithMessage("O campo Cidade não pode ser nulo");

            RuleFor(x => x.PersonInfo.Birthday)
                .NotEmpty().WithName("Aniversário").WithMessage("O campo Aniversário não pode ser vazio.")
                .NotNull().WithName("Aniversário").WithMessage("O campo Aniversário não pode ser nulo");

            RuleFor(x => x.PersonInfo.Name)
                .NotEmpty().WithName("Nome").WithMessage("O campo Nome não pode ser vazio.")
                .NotNull().WithName("Nome").WithMessage("O campo Nome não pode ser nulo");


            RuleFor(x => x.PersonInfo.Surname)
                .NotEmpty().WithName("Sobrenome").WithMessage("O campo Sobrenome não pode ser vazio.")
                .NotNull().WithName("Sobrenome").WithMessage("O campo Sobrenome não pode ser nulo");

            RuleFor(x => x.PersonInfo.CPF)
                .NotEmpty().WithName("CPF").WithMessage("O campo CPF não pode ser vazio.")
                .NotNull().WithName("CPF").WithMessage("O campo CPF não pode ser nulo.")
                .Must(x => ValidateCpf(x)).WithMessage("O campo CPF é inválido");

        }

        private static bool ValidateCpf(string cpf)
        {
            cpf = cpf.Trim();
            if(cpf.Length > 14)
            {
                return false;
            }

            cpf = cpf.Replace(".", "").Replace("-", "");
            if (!Regex.IsMatch(cpf, "^[0-9]*$") || cpf.Length > 11 || cpf.Length < 11)
            {
                return false;
            }
            return true;
        }
    }
}
