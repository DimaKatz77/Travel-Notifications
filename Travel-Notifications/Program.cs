using Microsoft.Extensions.DependencyInjection.Extensions;
using Travel_Notifications.Services;
using Travel_Notifications.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.TryAddScoped<IFlightInfoService,FlightInfoService>();
builder.Services.TryAddScoped<INotificationService, NotificationService>();
builder.Services.TryAddScoped<ISearchService, SearchService>();
builder.Services.TryAddScoped<IUserService, UserService>();
var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
