using System.Threading.Tasks;
using TodosAppABP.Models.TokenAuth;
using TodosAppABP.Web.Controllers;
using Shouldly;
using Xunit;

namespace TodosAppABP.Web.Tests.Controllers
{
    public class HomeController_Tests: TodosAppABPWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}