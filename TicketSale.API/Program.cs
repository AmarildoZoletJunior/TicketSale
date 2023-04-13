using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using TicketSale.API.Ticket.Extensions;
using TicketSale.Application.Mapper;
using TicketSale.CrossCutting.Helper;
using TicketSale.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var configurationDTO = new MapperConfiguration(x => x.AddProfile(new MapToDTO()));
var configurationEntity = new MapperConfiguration(x => x.AddProfile(new MapToEntity()));
IMapper mapperEntity = configurationDTO.CreateMapper();
IMapper mapperDto = configurationEntity.CreateMapper();
builder.Services.AddSingleton(mapperEntity);
builder.Services.AddSingleton(mapperDto);

#region DependencyInjection

#endregion

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

#region DbConfiguration
builder.Services.AddDbContext<TicketContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionTicket")));
#endregion

builder.Services.RegisterExtensions(builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
