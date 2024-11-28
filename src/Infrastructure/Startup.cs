using System.Reflection;
using System.Runtime.CompilerServices;
using TD.KCN.WebApi.Infrastructure.Auth;
using TD.KCN.WebApi.Infrastructure.BackgroundJobs;
using TD.KCN.WebApi.Infrastructure.Caching;
using TD.KCN.WebApi.Infrastructure.Common;
using TD.KCN.WebApi.Infrastructure.Cors;
using TD.KCN.WebApi.Infrastructure.FileStorage;
using TD.KCN.WebApi.Infrastructure.Localization;
using TD.KCN.WebApi.Infrastructure.Mailing;
using TD.KCN.WebApi.Infrastructure.Mapping;
using TD.KCN.WebApi.Infrastructure.Middleware;
using TD.KCN.WebApi.Infrastructure.Multitenancy;
using TD.KCN.WebApi.Infrastructure.Notifications;
using TD.KCN.WebApi.Infrastructure.OpenApi;
using TD.KCN.WebApi.Infrastructure.Persistence;
using TD.KCN.WebApi.Infrastructure.Persistence.Initialization;
using TD.KCN.WebApi.Infrastructure.SecurityHeaders;
using TD.KCN.WebApi.Infrastructure.Validations;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TD.KCN.WebApi.Infrastructure.Minio;
using TD.KCN.WebApi.Infrastructure.Ldap;
using Asp.Versioning;
using Syncfusion.Licensing;

[assembly: InternalsVisibleTo("Infrastructure.Test")]

namespace TD.KCN.WebApi.Infrastructure;

public static class Startup
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        var applicationAssembly = typeof(TD.KCN.WebApi.Application.Startup).GetTypeInfo().Assembly;

        MapsterSettings.Configure();
        return services
            .AddApiVersioning()
            .AddAuth(config)
            .AddBackgroundJobs(config)
            .AddCaching(config)
            .AddCorsPolicy(config)
            .AddExceptionMiddleware()
            .AddBehaviours(applicationAssembly)
            .AddHealthCheck()
            .AddPOLocalization(config)
            .AddMailing(config)
            .AddTDMinio(config)
            .AddLdap(config)
            .AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()))
            .AddMultitenancy()
            .AddNotifications(config)
            .AddOpenApiDocumentation(config)
            .AddPersistence()
            .AddRequestLogging(config)
            .AddRouting(options => options.LowercaseUrls = true)
            .AddServices();
    }

    private static IServiceCollection AddApiVersioning(this IServiceCollection services) =>
        services.AddApiVersioning(config =>
        {
            config.DefaultApiVersion = new ApiVersion(1, 0);
            config.AssumeDefaultVersionWhenUnspecified = true;
            config.ReportApiVersions = true;
        }).Services;

    private static IServiceCollection AddHealthCheck(this IServiceCollection services) =>
        services.AddHealthChecks().AddCheck<TenantHealthCheck>("Tenant").Services;

    public static async Task InitializeDatabasesAsync(this IServiceProvider services, CancellationToken cancellationToken = default)
    {
        // Create a new scope to retrieve scoped services
        using var scope = services.CreateScope();

        await scope.ServiceProvider.GetRequiredService<IDatabaseInitializer>()
            .InitializeDatabasesAsync(cancellationToken);
    }

    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder builder, IConfiguration config) =>
        builder
            .UseRequestLocalization()
            .UseStaticFiles()
            .UseSecurityHeaders(config)
            .UseFileStorage()
            .UseExceptionMiddleware()
            .UseRouting()
            .UseCorsPolicy()
            .UseAuthentication()
            .UseCurrentUser()
            .UseMultiTenancy()
            .UseAuthorization()
            .UseRequestLogging(config)
            .UseHangfireDashboard(config)
            .UseOpenApiDocumentation(config);

    public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder builder)
    {
        builder.MapControllers().RequireAuthorization();
        builder.MapHealthCheck();
        builder.MapNotifications();
        return builder;
    }

    private static IEndpointConventionBuilder MapHealthCheck(this IEndpointRouteBuilder endpoints) =>
        endpoints.MapHealthChecks("/api/health");
}