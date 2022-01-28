using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ClothesBox.Controllers;

namespace ClothesBox.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AbpMvcAuthorize]
    public class HomeController : ClothesBoxControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
