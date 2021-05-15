using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Models;

namespace WebAppWithAdmin.Areas.Admin.ViewModels
{
	public class PostIndexViewModel
	{
		public ICollection<Post> Posts { get; set; }
	}
}
