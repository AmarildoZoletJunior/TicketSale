using NSubstitute;
using NSubstitute.ReturnsExtensions;
using TicketSale.Application.DTOs.ResponseDTO;
using TicketSale.Application.Services.ClientServices;
using TicketSale.Data.UnitOfWork;
using TicketSale.Domain.Entities.CityEntity;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Interfaces;

namespace TicketSale.Tests.ServicesTests
{
    public class ClientServiceTests
    {
        private readonly IUnitOfWorkRepository _unit = Substitute.For<IUnitOfWorkRepository>();
        private readonly ClientService _sut;
        private readonly IClientRepository _client = Substitute.For<IClientRepository>();
        private readonly ICityRepository _city = Substitute.For<ICityRepository>();
        public ClientServiceTests()
        {
            _sut = new ClientService(_unit,_client,_city);
        }

        [Fact]
        public async Task ReturnNullWhenNoCityFoundAsync()
        {
            Client client = new Client
            {
                AdressInfo = "Rua teste",
                CityId = 2,
                Email = "teste@gmail.com",
                Id = 0,
                Password = "Password@",
                PersonInfo = new Domain.VO.PersonInfo
                {
                    Birthday = DateTime.UtcNow,
                    CPF = "12312312312",
                    Name = "Name",
                    Surname = "Surname"
                }
            };

            City city = new City
            {
                CityName = "Name",
                Id = 50,
                StateId = 20,
            };
            var error = new MessageError("Cidade não encontrada", "O id da cidade fornecida não foi encontrado no banco");
            _city.FindByIdAsync(client.CityId).ReturnsNull();
            var resultado = await _sut.CreateUser(client);


            Assert.False(resultado.Success);
            Assert.Null(resultado.Data);
            Assert.True(resultado.Messages!.Exists(x => x.Message == error.Message && x.TitleError == error.TitleError));
        }

        [Fact]
        public async Task ReturnErrorWhenCPFIsUsedAsync()
        {
            Client client = new Client
            {
                AdressInfo = "Rua teste",
                CityId = 2,
                Email = "teste@gmail.com",
                Id = 0,
                Password = "Password@",
                PersonInfo = new Domain.VO.PersonInfo
                {
                    Birthday = DateTime.UtcNow,
                    CPF = "12312312312",
                    Name = "Name",
                    Surname = "Surname"
                }
            };

            City city = new City
            {
                CityName = "Name",
                Id = 50,
                StateId = 20,
            };
           
            _city.FindByIdAsync(client.CityId).Returns(city);
            _client.CPFIsUsed(client.PersonInfo.CPF).Returns(true);
            var resultado = await _sut.CreateUser(client);

            var error = new MessageError("CPF já esta em uso", "Este CPF já esta sendo registrado no banco");

            Assert.False(resultado.Success);
            Assert.Null(resultado.Data);
            Assert.True(resultado.Messages!.Exists(x => x.Message == error.Message && x.TitleError == error.TitleError));
        }

        [Fact]
        public async Task ReturnErrorWhenEmailIsUsedAsync()
        {
            Client client = new Client
            {
                AdressInfo = "Rua teste",
                CityId = 2,
                Email = "teste@gmail.com",
                Id = 0,
                Password = "Password@",
                PersonInfo = new Domain.VO.PersonInfo
                {
                    Birthday = DateTime.UtcNow,
                    CPF = "12312312312",
                    Name = "Name",
                    Surname = "Surname"
                }
            };

            City city = new City
            {
                CityName = "Name",
                Id = 50,
                StateId = 20,
            };

            _city.FindByIdAsync(client.CityId).Returns(city);
            _client.EmailIsUsed(client.Email).Returns(true);
            var resultado = await _sut.CreateUser(client);

            var error = new MessageError("Email já esta em uso", "Este email já esta sendo registrado no banco");

            Assert.False(resultado.Success);
            Assert.Null(resultado.Data);
            Assert.True(resultado.Messages!.Exists(x => x.Message == error.Message && x.TitleError == error.TitleError));
        }



        [Theory]
        //CPF
        [InlineData("amarildozj@gmail.com","Junior@",29,"Rua teste","1231231231","Amarildo","Zolet", "PersonInfo.CPF", "O campo CPF é inválido")]
        [InlineData("amarildozj@gmail.com", "Junior@", 29, "Rua teste", "123.asd.123-12", "Amarildo", "Zolet", "PersonInfo.CPF", "O campo CPF é inválido")]
        [InlineData("amarildozj@gmail.com", "Junior@", 29, "Rua teste", "asd.asd.asd-as", "Amarildo", "Zolet", "PersonInfo.CPF", "O campo CPF é inválido")]
        [InlineData("amarildozj@gmail.com", "Junior@", 29, "Rua teste", "123.123.123-1", "Amarildo", "Zolet", "PersonInfo.CPF", "O campo CPF é inválido")]
        [InlineData("amarildozj@gmail.com", "Junior@", 29, "Rua teste", "", "Amarildo", "Zolet", "PersonInfo.CPF", "O campo CPF não pode ser vazio.")]
        //Email
        [InlineData("amarildozj.com", "Junior@", 29, "Rua teste", "123.123.123-12", "Amarildo", "Zolet", "Email", "O campo email esta inválido.")]
        [InlineData("amarildo@", "Junior@", 29, "Rua teste", "123.123.123-12", "Amarildo", "Zolet", "Email", "O campo email esta inválido.")]
        [InlineData("", "Junior@", 29, "Rua teste", "123.123.123-12", "Amarildo", "Zolet", "Email", "O campo email não pode ser vazio.")] 
        [InlineData(null, "Junior@", 29, "Rua teste", "123.123.123-12", "Amarildo", "Zolet", "Email", "O campo email não pode ser nulo.")]
        //Name
        [InlineData("amarildozj@gmail.com", "Junior@", 29, "Rua teste", "123.123.123-12", "", "Zolet", "PersonInfo.Name", "O campo Nome não pode ser vazio.")]
        [InlineData("amarildozj@gmail.com", "Junior@", 29, "Rua teste", "123.123.123-12", null, "Zolet", "PersonInfo.Name", "O campo Nome não pode ser nulo")]
        //Surname
        [InlineData("amarildozj@gmail.com", "Junior@", 29, "Rua teste", "123.123.123-12", "Amarildo", "", "PersonInfo.Surname", "O campo Sobrenome não pode ser vazio.")]
        [InlineData("amarildozj@gmail.com", "Junior@", 29, "Rua teste", "123.123.123-12", "Amarildo", null, "PersonInfo.Surname", "O campo Sobrenome não pode ser nulo")]
        //AddressInfo
        [InlineData("amarildozj@gmail.com", "Junior@", 29, "", "123.123.123-12", "Amarildo", "Zolet", "AdressInfo", "O campo Endereço não pode ser vazio.")]
        [InlineData("amarildozj@gmail.com", "Junior@", 29, null, "123.123.123-12", "Amarildo", "Zolet", "AdressInfo", "O campo Endereço não pode ser nulo")]
        //Password
        [InlineData("amarildozj@gmail.com", "Junior", 29, "Rua teste", "123.123.123-12", "Amarildo", "Zolet", "Password", "O campo Senha não atendeu aos requisitos.")]
        [InlineData("amarildozj@gmail.com", "junior@", 29, "Rua teste", "123.123.123-12", "Amarildo", "Zolet", "Password", "O campo Senha não atendeu aos requisitos.")]
        [InlineData("amarildozj@gmail.com", "J@", 29, "Rua teste", "123.123.123-12", "Amarildo", "Zolet", "Password", "O campo Senha deve conter no mínimo 4 caracteres.")]
        [InlineData("amarildozj@gmail.com", null, 29, "Rua teste", "123.123.123-12", "Amarildo", "Zolet", "Password", "O campo Senha não pode ser nulo")]
        [InlineData("amarildozj@gmail.com", "", 29, "Rua teste", "123.123.123-12", "Amarildo", "Zolet", "Password", "O campo Senha não pode ser vazia.")]
        public async Task ReturnErrorWhenValidateIsFalseAsync(string email,string password,int cityId, string address, string cpf,string name, string surname,string propertyname,string errormessage)
        {
            Client client = new Client
            {
                AdressInfo = address,
                CityId = cityId,
                Email = email,
                Id = 0,
                Password = password,
                PersonInfo = new Domain.VO.PersonInfo
                {
                    Birthday = DateTime.UtcNow,
                    CPF = cpf,
                    Name = name,
                    Surname = surname
                }
            };

            City city = new City
            {
                CityName = "Name",
                Id = 50,
                StateId = 20,
            };

            var resultado = await _sut.CreateUser(client);

            var error = new MessageError(propertyname, errormessage);

            Assert.False(resultado.Success);
            Assert.Null(resultado.Data);
            Assert.True(resultado.Messages!.Exists(x => x.Message == error.Message && x.TitleError == error.TitleError));
        }
    }
}
