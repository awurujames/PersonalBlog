using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Data;
using WebAppWithAdmin.Areas.Admin.Models;

namespace WebAppWithAdmin.Areas.Admin.Repository
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public CategoryRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public bool AddCategory(Category category)
		{
			_dbContext.Categories.Add(category);
			_dbContext.SaveChanges();
			return true;
		}

		public ICollection<Category> GetAll()
		{
			return _dbContext.Categories.ToList();
		}

		public bool RemoveCategory(int Id)
		{
			var category = _dbContext.Categories.Find(Id);

			_dbContext.Categories.Remove(category);

			_dbContext.SaveChanges();

			return true;
		}
	}
}
