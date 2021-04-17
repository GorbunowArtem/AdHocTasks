using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CFX;
using CFX.ResourcePerformance;
using GenericMediatr.Handlers;
using GenericMediatr.Parsers;
using GenericMediatr.Requests;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace GenericMediatr
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo {Title = "GenericMediatr", Version = "v1"});
			});
			services.AddSingleton<ICfxMessageTypeProvider, CfxMessageTypeProvider>();


			
			services.AddScoped<IRequestHandler<ParseCfxMessageRequest<FaultOccurred>, Unit>,
				ParseCfxMessageRequestHandler<FaultOccurred, ParseCfxMessageRequest<FaultOccurred>>>();
			
			services.AddScoped<IRequestHandler<ParseCfxMessageRequest<FaultCleared>, Unit>,
				ParseCfxMessageRequestHandler<FaultCleared, ParseCfxMessageRequest<FaultCleared>>>();

			services.AddScoped<IMessageParser<FaultCleared>, FaultClearedParser>();
			services.AddScoped<IMessageParser<FaultOccurred>, FaultOccuredParser>();
			
			services.AddMediatR(Assembly.GetExecutingAssembly());
			// services.AddSingleton<IRequestHandler<FaultClearedRequest>,
			// 		ParseCfxMessageRequestHandler<FaultCleared, FaultClearedRequest>>();
			
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GenericMediatr v1"));
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
		}
		
		public interface ICfxMessageTypeProvider
		{
			IEnumerable<Type> GetMessages();
		}
		
		public class CfxMessageTypeProvider: ICfxMessageTypeProvider
		{
			public IEnumerable<Type> GetMessages()
			{
				return new[]
				{
					typeof(FaultCleared),
					typeof(FaultOccurred)
				};
			}
		}
	}
}