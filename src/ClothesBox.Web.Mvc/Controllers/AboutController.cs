using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ClothesBox.Controllers;

namespace ClothesBox.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ClothesBoxControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
