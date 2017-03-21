using System.Collections.Generic;
using System.Linq;
using FirstApp.Abstract;
using FirstApp.Controllers;
using FirstApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstApp.Tests
{

	[TestClass]
	public class AdminControllerTest
	{
		[TestMethod]
		public void CanChangeLoginName()
		{
			//AAA
			var user = new User { LoginName = "Stefan" };
			var repository = new FakeRepository();
			repository.Add(user);

			var target = new AdminController(repository);
			var oldLogin = user.LoginName;
			var newLogin = "Bogdan";

			target.ChangeLoginName(oldLogin, newLogin);

			Assert.AreEqual(newLogin, user.LoginName);
			Assert.IsTrue(repository.DidSubmitChanges);
		}


		class FakeRepository : IUserRepository
		{
			public List<User> Users = new List<User>();
			public bool DidSubmitChanges = false;

			public void Add(User user)
			{
				Users.Add(user);
			}

			public User FetchByLoginName(string loginName)
			{
				return Users.FirstOrDefault(u => u.LoginName == loginName);
			}

			public bool SubmitChanges()
			{
				return DidSubmitChanges = true;
			}
		}
	}

}
