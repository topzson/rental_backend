using Microsoft.OpenApi.Models;

namespace EtaxService.Installers
{
    public static class SwaggerInstaller
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Etax Service", Version = "v1" });
            
            });

            return services;
        }
    }
} 