using TD.KCN.WebApi.Application;
using TD.KCN.WebApi.Host.Configurations;
using TD.KCN.WebApi.Host.Controllers;
using TD.KCN.WebApi.Infrastructure;
using TD.KCN.WebApi.Infrastructure.Common;
using TD.KCN.WebApi.Infrastructure.Logging.Serilog;
using Serilog;
using Microsoft.Extensions.FileProviders;

[assembly: ApiConventionType(typeof(TDApiConventions))]

StaticLogger.EnsureInitialized();
Log.Information("Server Booting Up...");
try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.AddConfigurations().RegisterSerilog();
    builder.Services.AddControllers();
    builder.Services.AddInfrastructure(builder.Configuration);

    builder.Services.AddApplication();

    builder.Services.AddSpaStaticFiles(c =>
    {
        c.RootPath = "ClientApp";
    });

    var app = builder.Build();

    await app.Services.InitializeDatabasesAsync();

    app.UseInfrastructure(builder.Configuration);

    app.UseStaticFiles(new StaticFileOptions
    {
        FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "Uploads")),
        RequestPath = "/Uploads"
    });
    app.UseSpaStaticFiles();

    app.UseSpa(spa =>
    {
        spa.Options.SourcePath = "ClientApp";
    });

    app.MapEndpoints();
    app.Run();
}
catch (Exception ex) when (!ex.GetType().Name.Equals("HostAbortedException", StringComparison.Ordinal))
{
    StaticLogger.EnsureInitialized();
    Log.Fatal(ex, "Unhandled exception");
}
finally
{
    StaticLogger.EnsureInitialized();
    Log.Information("Server Shutting down...");
    Log.CloseAndFlush();
}