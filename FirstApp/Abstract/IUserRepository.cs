using FirstApp.Models;

namespace FirstApp.Abstract
{

	public interface IUserRepository
	{
		void Add(User user);
		User FetchByLoginName(string loginName);
		bool SubmitChanges();
	}

}
