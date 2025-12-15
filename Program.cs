
using EtteremApi.Models;
using EtteremApi.Models.Dtos;
using EtteremApi.Services;
using EtteremApi.Services.IRestaurant;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace EtteremApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<EtteremContext>(option =>
            {
                var ConnctionString = builder.Configuration.GetConnectionString("MySQL");
                option.UseMySQL(ConnctionString);
            });

            builder.Services.AddScoped<IRendeles,RendelesService>();
            builder.Services.AddScoped<ITermekek, TermekekServices>();
            builder.Services.AddScoped<IKapcsolo, KapcsoloService>();
            builder.Services.AddScoped<ResultResponseDto>();

            builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            // Add services to the container.

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
        }
    }
}
