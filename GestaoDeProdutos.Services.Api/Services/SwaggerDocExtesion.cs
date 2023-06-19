using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace GestaoDeProdutos.Services.Api.Services
{
    /// <summary>
    /// Classe para extensão para adicionarmos no projeto as config de geração da documentação7
    /// do Swagger (openapi)
    /// </summary>
    public static class SwaggerDocExtesion
    {
        ///Personalizando o conteudo da documentação gerada
        public static IServiceCollection AddSwaggerDoc(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "API de controle de produtos",
                    Description = "API REST desenvolvida em AspNet 7 com EntityFramework",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Ágatha Almeida",
                        Email = "contatoagathaofc@gmail.com",
                        //Url = new Uri("www.linkedin.com/in/ágatha-santosdev")
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);

            });

            return services;
        }

        ///Configurando a execução da página de documentação
        public static IApplicationBuilder UseSwaggerDoc(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "GestaoDeProdutos.Services.Api.Services");
            });
            return app;
        }
    }
}
