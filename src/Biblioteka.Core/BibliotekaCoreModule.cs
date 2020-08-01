using Abp.Modules;
using Abp.Reflection.Extensions;
using Biblioteka.Localization;

namespace Biblioteka
{
    public class BibliotekaCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            BibliotekaLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BibliotekaCoreModule).GetAssembly());
        }
    }
}