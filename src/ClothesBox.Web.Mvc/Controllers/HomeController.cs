using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ClothesBox.Controllers;

namespace ClothesBox.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ClothesBoxControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
