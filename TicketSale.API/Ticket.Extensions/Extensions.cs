using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using TicketSale.Application.Interfaces;
using TicketSale.Application.Services.ClientServices;
using TicketSale.Application.Services.CurrencyServices;
using TicketSale.Application.Services.TokenServices;
using TicketSale.Application.Validators;
using TicketSale.Data.Repositories;
using TicketSale.Data.UnitOfWork;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Interfaces;

namespace TicketSale.API.Ticket.Extensions
{
    public static class Extensions
    {
        public static IServiceCollection RegisterExtensions(this IServiceCollection collection, IConfiguration configuration)
        {
            #region Repositories
            collection.AddScoped<IArtistRepository, ArtistRepository>();
            collection.AddScoped<ICurrencyRepository, CurrencyRepository>();
            collection.AddScoped<IClientRepository, ClientRepository>();
            collection.AddScoped<ICityRepository, CityRepository>();
            collection.AddScoped<IUnitOfWorkRepository, UnitOfWorkRepository>();
            #endregion

            #region Validators
            collection.AddScoped<IValidator<Client>, ClientValidator>();
            #endregion

            #region Services
            collection.AddScoped<ITokenService, TokenService>();
            collection.AddScoped<ICurrencyService, CurrencyService>();
            collection.AddScoped<IClientService, ClientService>();
            #endregion

            #region JWTConfiguration

            var key = Encoding.ASCII.GetBytes(configuration["JwtToken"]);


            collection.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });



            collection.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    Description = "JWT Authorization Header - utilizado com Bearer Authentication.\r\n\r\n" +
                        "Digite 'Bearer' [espaço] e então seu token no campo abaixo.\r\n\r\n" +
                        "Exemplo (informar sem as aspas): 'Bearer 12345abcdef'",
                    BearerFormat = "JWT",


                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                 {
                      {
                         new OpenApiSecurityScheme
                             {
                                  Reference = new OpenApiReference
                                    {
                                         Type = ReferenceType.SecurityScheme,
                                         Id = "Bearer"
                                     },
                         Scheme = "oauth2",
                         Name = "Bearer",
                         In = ParameterLocation.Header,

                             },
                              new List<string>()
                      }
                });

            });
            #endregion

            return collection;
        }
    }
}
