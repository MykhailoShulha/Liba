using Abp.AspNetCore.Mvc.Views;

namespace Biblioteka.Web.Views
{
    public abstract class BibliotekaRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected BibliotekaRazorPage()
        {
            LocalizationSourceName = BibliotekaConsts.LocalizationSourceName;
        }
    }
}
