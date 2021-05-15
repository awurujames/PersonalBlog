using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppWithAdmin.Areas.Admin.Models
{
	public class Category : BaseModel
	{
		[Required]
		public string CategoryName { get; set; }
		public ICollection<Post> Posts { get; set; }
	}
}
