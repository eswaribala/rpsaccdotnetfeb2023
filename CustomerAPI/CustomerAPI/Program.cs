using CustomerAPI.Contexts;
using CustomerAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//External Configuration
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

// Add services to the container.
//builder.Services.AddDbContext<BankingContext>(options => options
//.UseSqlServer(configuration.GetConnectionString("DbConn")));
Dictionary<String, Object> data = new VaultConfiguration(configuration).GetDBCredentials().Result;
Console.WriteLine(data);
SqlConnectionStringBuilder providerCs = new SqlConnectionStringBuilder();
providerCs.InitialCatalog = data["dockerdbname"].ToString();
providerCs.UserID = data["dockerusername"].ToString();
providerCs.Password = data["dockerpassword"].ToString();
providerCs.DataSource = "localhost,1406";

//providerCs.UserID = CryptoService2.Decrypt(ConfigurationManager.AppSettings["UserId"]);
providerCs.MultipleActiveResultSets = true;
providerCs.TrustServerCertificate = false;

builder.Services.AddDbContext<BankingContext>(o => o.UseSqlServer(providerCs.ToString()));




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<ICustomerRepo, CustomerRepo>();
//builder.Services.AddApiVersioning();
builder.Services.AddApiVersioning(x =>
{
    x.DefaultApiVersion = new ApiVersion(1, 0);
    x.AssumeDefaultVersionWhenUnspecified = true;
    x.ReportApiVersions = true;
    x.ApiVersionReader = new HeaderApiVersionReader("x-api-version");
});

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(builder =>
{
    builder
    .WithOrigins("http://localhost:4200", "http://localhost:3000", "http://localhost:7072")
    .WithMethods("PUT", "DELETE", "GET", "POST")
    .AllowAnyHeader();


});

app.UseAuthorization();

app.MapControllers();

app.Run();
