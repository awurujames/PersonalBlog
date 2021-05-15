using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Models;

namespace WebAppWithAdmin.Areas.Admin.ViewModels
{
	public class UserIndexViewModel
	{
		public IEnumerable<ApplicationUser> ApplicationUsers { get; set; }
	}
}
