using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Models;

namespace WebAppWithAdmin.Areas.Admin.ViewModels
{
	public class UserAddViewModel
	{
		public ApplicationUser ApplicationUser { get; set; }
		public string StatusMessage { get; set; }
	}
}
