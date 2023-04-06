using Microsoft.EntityFrameworkCore;
using NsisongInvoiceV1.Models;
using Microsoft.Extensions.DependencyInjection;
using NsisongInvoiceV1.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<OrgContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OrgContext") ?? throw new InvalidOperationException("Connection string 'OrgContext' not found.")));
builder.Services.AddDbContext<UserContext>(opt => opt.UseInMemoryDatabase("UserList"));

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "NestlyPay OS API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
