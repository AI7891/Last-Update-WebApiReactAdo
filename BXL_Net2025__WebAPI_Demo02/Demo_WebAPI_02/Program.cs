using Demo_WebAPI_02.Repositories;
using Microsoft.Data.SqlClient;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);

const string CONNECTION_STRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";

// Add services to the container (C'est magic -> On vera ca en dev :p)
builder.Services.AddTransient<PlanetRepository>();
builder.Services.AddTransient<SolarSystemRepository>();
builder.Services.AddTransient<StarRepository>();
builder.Services.AddTransient<DbConnection>(proviver =>
{
    DbConnection connection = new SqlConnection(CONNECTION_STRING);
    connection.Open();
    return connection;
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
