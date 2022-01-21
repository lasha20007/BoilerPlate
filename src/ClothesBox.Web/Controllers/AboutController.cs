using System.Web.Mvc;

namespace ClothesBox.Web.Controllers
{
    public class AboutController : ClothesBoxControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}