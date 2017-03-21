using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApp.Abstract;

namespace FirstApp.Controllers
{
    public class AdminController : Controller
    {
	    IUserRepository _userRepository;

	    public AdminController(IUserRepository userRepository)
	    {
		    _userRepository = userRepository;
	    }

	    public ActionResult ChangeLoginName(string oldLogin, string newLogin)
	    {
		    var user = _userRepository.FetchByLoginName(oldLogin);
		    user.LoginName = newLogin;
		    _userRepository.SubmitChanges();

		    return View();
	    }
    }
}