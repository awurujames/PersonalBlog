using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Data;
using WebAppWithAdmin.Areas.Admin.Models;

namespace WebAppWithAdmin.Areas.Admin.Repository
{
	public class PostRepository : IPostRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public PostRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public bool AddPost(Post post)
		{
			_dbContext.Posts.Add(post);
			_dbContext.SaveChanges();
			return true;
		}

		public ICollection<Post> GetAll()
		{
			return _dbContext.Posts.OrderByDescending(p => p.Title).Include(p => p.Category).Include(p => p.ApplicationUser).ToList();
		}

		public bool RemovePost(int Id)
		{
			var post = _dbContext.Posts.Find(Id);
			_dbContext.Posts.Remove(post);
			_dbContext.SaveChanges();
			return true;
		}

		public Post GetPost(int Id)
		{
			var post = _dbContext.Posts.Where( p => p.Id == Id).Include(p => p.Category).Include(p => p.ApplicationUser).FirstOrDefault();

			return post;
		}

		public bool UpdatePost(Post post)
		{
			_dbContext.Posts.Update(post);
			_dbContext.SaveChanges();
			return true;
		}

    }
}
