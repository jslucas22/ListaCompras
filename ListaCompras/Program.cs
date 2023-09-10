using ListaCompras.Domain.Models.Database;
using ListaComrpas.Business.Services.Abstractions.Items;
using ListaComrpas.Business.Services.Abstractions.User;
using ListaComrpas.Business.Services.Items;
using ListaComrpas.Business.Services.User;
using ListaComrpas.Data.Repositories.Abstractions.Items;
using ListaComrpas.Data.Repositories.Abstractions.User;
using ListaComrpas.Data.Repositories.Items;
using ListaComrpas.Data.Repositories.User;

var builder = WebApplication.CreateBuilder(args);

var env = builder.Environment;

builder.Configuration
       .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
       .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: false, reloadOnChange: true);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IItemProductService, ItemProductService>();
builder.Services.AddScoped<IItemProductRepository, ItemProductRepository>();
builder.Services.AddScoped<IItemCartService, ItemCartService>();
builder.Services.AddScoped<IItemCartRepository, ItemCartRepository>();

DbStaticDefaults.ConnectionString = builder.Configuration.GetValue<string>("ConnectionStrings:connection");

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
