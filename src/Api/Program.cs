using MediatorPatern.Api.Extensions;

WebApplication BuildApp(string[] args)
{
    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddOpenApi();
    builder.Services.AddDocumentation();
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
