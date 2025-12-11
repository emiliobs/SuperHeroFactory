using AutoMapper; // importante para que se vea AddAutoMapper
using SuperHero.Application;
using SuperHero.Application.Mapping;
using SuperHero.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

// AutoMapper: scan profiles starting from SuperHeroProfile
builder.Services.AddAutoMapper(cfg => { }, typeof(ToyProfile));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// For to be able to login with token using Swgeer testing.

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();
app.UseCors();
app.MapControllers();

app.Run();