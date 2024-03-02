using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using FitNet.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

var dbAddress = config["Database:PgAddress"];
var dbName = config["Database:DbName"];
var dbUser = config["Database:PgUser"];
var dbPassword = config["Database:PgPass"];

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.Authority = config["Authentication:Authority"];
        options.Audience = config["Authenitcation:Audience"];
    });
builder.Services.AddAuthorization();

builder.Services.AddControllers();
builder.Services.AddDbContext<FitnessContext>(opt => opt.UseNpgsql($"Host={dbAddress};Database={dbName};Username={dbUser};Password={dbPassword}"));
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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
