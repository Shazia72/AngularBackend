
using AngularPojectBackend.data;
using AngularPojectBackend.Intreface;
using AngularPojectBackend.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace AngularPojectBackend
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection")));
			builder.Services.AddScoped<IBankAccount, BankAccountRepo>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseCors(policy =>
			policy.WithOrigins("http://localhost:4200", "https://localhost:4200")
			.AllowAnyMethod()
			.WithHeaders(HeaderNames.ContentType)
			);
			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
