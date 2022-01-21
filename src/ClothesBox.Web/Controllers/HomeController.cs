using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

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