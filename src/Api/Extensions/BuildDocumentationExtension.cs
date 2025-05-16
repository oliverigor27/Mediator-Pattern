using Microsoft.OpenApi.Models;

namespace MediatorPatern.Api.Extensions;

public static class BuildDocumentationExtension
{
    public static IServiceCollection AddDocumentation(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(option => {
            option.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Mediator API",
                Description = "A lightweight and flexible library for implementing the Mediator pattern in C#, enabling decoupled communication between components.",
                License = new OpenApiLicense
                {
                    Name = "MIT",
                    Url = new Uri("https://github.com/oliverigor27/Mediator-Pattern/blob/main/LICENSE")
                }
            });
        });

        return services;
    }

    public static WebApplication UseDocumentation(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        return app;
    }
}
