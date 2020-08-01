using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Biblioteka.Configuration;
using Biblioteka.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace Biblioteka.Web.Startup
{
    [DependsOn(
        typeof(BibliotekaApplicationModule), 
        typeof(BibliotekaEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class BibliotekaWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public BibliotekaWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(BibliotekaConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<BibliotekaNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(BibliotekaApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BibliotekaWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BibliotekaWebModule).Assembly);
        }
    }
}