using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Models;

namespace WebAppWithAdmin.ViewModels
{
	public class HomeIndexViewModel
	{
		public ICollection<Post> Posts { get; set; }
		public ICollection<Post> slidePosts
        {
            get
            {
                return Posts.Take(5).ToList();
            }
        }

        public ICollection<Post> slidePosts2
        {
            get
            {
                return Posts.Skip(5).Take(5).ToList();
            }
        }

    }
}
