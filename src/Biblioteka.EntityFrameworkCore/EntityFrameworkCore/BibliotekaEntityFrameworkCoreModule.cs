using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Biblioteka.EntityFrameworkCore
{
    [DependsOn(
        typeof(BibliotekaCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class BibliotekaEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BibliotekaEntityFrameworkCoreModule).GetAssembly());
        }
    }
}