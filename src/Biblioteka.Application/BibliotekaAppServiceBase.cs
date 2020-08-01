using Abp.Application.Services;

namespace Biblioteka
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BibliotekaAppServiceBase : ApplicationService
    {
        protected BibliotekaAppServiceBase()
        {
            LocalizationSourceName = BibliotekaConsts.LocalizationSourceName;
        }
    }
}