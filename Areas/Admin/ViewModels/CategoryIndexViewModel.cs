using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Models;

namespace WebAppWithAdmin.Areas.Admin.ViewModels
{
	public class CategoryIndexViewModel
	{
		public ICollection<Category> Categories { get; set; }
	}
}
