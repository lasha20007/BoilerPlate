using System.Threading.Tasks;
using ClothesBox.Models.TokenAuth;
using ClothesBox.Web.Controllers;
using Shouldly;
using Xunit;

namespace ClothesBox.Web.Tests.Controllers
{
    public class HomeController_Tests: ClothesBoxWebTestBase
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