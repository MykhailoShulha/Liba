using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Biblioteka.EntityFrameworkCore;
using Biblioteka.Tests.TestDatas;

namespace Biblioteka.Tests
{
    public class BibliotekaTestBase : AbpIntegratedTestBase<BibliotekaTestModule>
    {
        public BibliotekaTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<BibliotekaDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<BibliotekaDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<BibliotekaDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BibliotekaDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<BibliotekaDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<BibliotekaDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<BibliotekaDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BibliotekaDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
