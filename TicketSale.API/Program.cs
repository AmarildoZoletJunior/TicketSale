using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TicketSale.API.Ticket.Extensions;
using TicketSale.Application.Mapper;
using TicketSale.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

IEnumerable<Profile> profiles = new List<Profile>
        {
           new MapToEntity(),
           new MapToDTO()
        };
var configurationDTO = new MapperConfiguration(x => x.AddProfiles(profiles));
IMapper mapperEntity = configurationDTO.CreateMapper();
builder.Services.AddSingleton(mapperEntity);

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

app.UseCors(builder => builder.AllowAnyOrigin()
                                  .AllowAnyHeader()
                                  .AllowAnyMethod());
app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
