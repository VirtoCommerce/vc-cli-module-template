using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VirtoCommerce.Platform.Core.Modularity;
using VirtoCommerce.Platform.Core.Security;
using VirtoCommerce.Platform.Core.Settings;
using VirtoCommerce.Platform.Data.SqlServer.Extensions;
using {Namespace}.Core;
using {Namespace}.Data.Repositories;

namespace {Namespace}.Web;

public class Module : IModule, IHasConfiguration
{
    public ManifestModuleInfo ModuleInfo { get; set; }
    public IConfiguration Configuration { get; set; }

    public void Initialize(IServiceCollection serviceCollection)
    {
        // Initialize database
        var connectionString = Configuration.GetConnectionString(ModuleInfo.Id) ?? Configuration.GetConnectionString("VirtoCommerce");

        serviceCollection.AddDbContext<{ModuleName}DbContext>(options =>
            options.UseSqlServerDatabase(connectionString, typeof(SqlServerDataAssemblyMarker), Configuration));

        // Override models
        //AbstractTypeFactory<OriginalModel>.OverrideType<OriginalModel, ExtendedModel>().MapToType<ExtendedEntity>();
        //AbstractTypeFactory<OriginalEntity>.OverrideType<OriginalEntity, ExtendedEntity>();

        // Register services
        //serviceCollection.AddTransient<IMyService, MyService>();
    }

    public void PostInitialize(IApplicationBuilder appBuilder)
    {
        var serviceProvider = appBuilder.ApplicationServices;

        // Register settings
        var settingsRegistrar = serviceProvider.GetRequiredService<ISettingsRegistrar>();
        settingsRegistrar.RegisterSettings(ModuleConstants.Settings.AllSettings, ModuleInfo.Id);

        // Register permissions
        var permissionsRegistrar = serviceProvider.GetRequiredService<IPermissionsRegistrar>();
        permissionsRegistrar.RegisterPermissions(ModuleInfo.Id, "{ModuleName}", ModuleConstants.Security.Permissions.AllPermissions);

        // Apply migrations
        using var serviceScope = serviceProvider.CreateScope();
        using var dbContext = serviceScope.ServiceProvider.GetRequiredService<{ModuleName}DbContext>();
        dbContext.Database.Migrate();
    }

    public void Uninstall()
    {
        // Nothing to do here
    }
}
