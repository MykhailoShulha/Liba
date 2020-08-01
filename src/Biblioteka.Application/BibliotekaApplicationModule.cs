using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Biblioteka
{
    [DependsOn(
        typeof(BibliotekaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BibliotekaApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BibliotekaApplicationModule).GetAssembly());
        }
    }
}