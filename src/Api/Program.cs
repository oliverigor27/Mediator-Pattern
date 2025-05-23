using MediatorPatern.Api.Extensions;
using MediatorPattern.Application.Extensions;

WebApplication BuildApp(string[] args)
{
    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddOpenApi();
    builder.Services.AddDocumentation();
    builder.Services.AddApplicationServices();
    return builder.Build();
}

void RunApp(WebApplication app)
{
    if (app.Environment.IsDevelopment())
    {
        app.MapOpenApi();
    }
    
    app.UseHttpsRedirection();
    app.UseDocumentation();
    app.UseEndpoint();
    app.Run();
}

RunApp(BuildApp(args));
