using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Models;

namespace WebAppWithAdmin.Areas.Admin.Repository
{
	public interface IPostRepository
	{
		bool AddPost(Post post);
		bool RemovePost(int Id);
		ICollection<Post> GetAll();
		Post GetPost(int Id);
		bool UpdatePost(Post post);

	}
}
