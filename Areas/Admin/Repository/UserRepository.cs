using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Data;
using WebAppWithAdmin.Areas.Admin.Models;

namespace WebAppWithAdmin.Areas.Admin.Repository
{
	public class UserRepository : IUserRepository
	{
		private ApplicationDbContext dbContext;

		public UserRepository(ApplicationDbContext applicationDbContext)
		{
			dbContext = applicationDbContext;
		}

		public bool AddUser(ApplicationUser user)
		{
			var result = dbContext.ApplicationUsers.Where(u => u.Email == user.Email).FirstOrDefault();

			if(result == null)
			{
				dbContext.ApplicationUsers.Add(user);
				dbContext.SaveChanges();
				return true;
			}
			return false;
		}


		public bool UpdateUser(ApplicationUser user)
		{
				dbContext.ApplicationUsers.Update(user);
				dbContext.SaveChanges();
				return true;
		}

		public IEnumerable<ApplicationUser> GetAllUsers()
		{
			return dbContext.ApplicationUsers.ToList();
		}

		public void RemoveUser(int id)
		{
			var user = dbContext.ApplicationUsers.Find(id);

			dbContext.ApplicationUsers.Remove(user);

			dbContext.SaveChanges();
		}

		public ApplicationUser GetUser(int Id)
		{
			return dbContext.ApplicationUsers.Find(Id);
		}
	}
}
