using Abp.AspNetCore.Mvc.Controllers;

namespace Biblioteka.Web.Controllers
{
    public abstract class BibliotekaControllerBase: AbpController
    {
        protected BibliotekaControllerBase()
        {
            LocalizationSourceName = BibliotekaConsts.LocalizationSourceName;
        }
    }
}