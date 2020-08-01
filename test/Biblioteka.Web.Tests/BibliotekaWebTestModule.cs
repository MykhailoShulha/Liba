using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Biblioteka.Web.Startup;
namespace Biblioteka.Web.Tests
{
    [DependsOn(
        typeof(BibliotekaWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class BibliotekaWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BibliotekaWebTestModule).GetAssembly());
        }
    }
}