using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Models;
using WebAppWithAdmin.Areas.Admin.ViewModels;

namespace WebAppWithAdmin.Areas.Admin.Repository
{
	public interface IUserRepository
	{
		bool AddUser(ApplicationUser user);
		bool UpdateUser(ApplicationUser user);
		IEnumerable<ApplicationUser> GetAllUsers();
		void RemoveUser(int id);
		ApplicationUser GetUser(int Id);

	}
}
