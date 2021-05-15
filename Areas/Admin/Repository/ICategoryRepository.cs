using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Models;

namespace WebAppWithAdmin.Areas.Admin.Repository
{
	public interface ICategoryRepository
	{
		ICollection<Category> GetAll();
		bool AddCategory(Category category);
		bool RemoveCategory(int Id);
	}
}
