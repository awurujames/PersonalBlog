using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppWithAdmin.Areas.Admin.ViewModels
{
	public class CategoryAddViewModel
	{
		[Required(ErrorMessage ="Please enter a category name")]
		[Display(Name ="Category name")]
		public string CategoryName { get; set; }
		public string StatusMessage { get; set; }
	}
}
