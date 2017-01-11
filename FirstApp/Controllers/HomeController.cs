using System.Web.Mvc;
using FirstApp.Models;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			/* var hour = DateTime.Now.Hour;
			 ViewBag.Greetings = hour < 17 ? "Dzien dobry" : "Dobranoc";
			*/
			return View();
        }

		
	    public ActionResult RsvpForm()
	    {
		    return View();
	    }

		[HttpPost]
	    public ActionResult RsvpForm(GuestResponse guestResponse)
	    {
		    return ModelState.IsValid ? View("Thanks",guestResponse) : View();
	    }


    }
}