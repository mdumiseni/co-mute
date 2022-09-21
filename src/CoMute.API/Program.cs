using CoMuteDAL.Library.CoMuteEntities;
using CoMuteDAL.Library.CoDbContext;

using Microsoft.EntityFrameworkCore;

namespace CoMute.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var connectionSring = builder.Configuration.GetConnectionString("CoMuteDb");
            builder.Services.AddDbContextPool<CoMuteDbContext>(option =>
            option.UseSqlServer(connectionSring));

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