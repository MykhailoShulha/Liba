using System.Threading.Tasks;
using Biblioteka.Web.Controllers;
using Shouldly;
using Xunit;

namespace Biblioteka.Web.Tests.Controllers
{
    public class HomeController_Tests: BibliotekaWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
