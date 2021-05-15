using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppWithAdmin.Areas.Admin.ViewModels
{
	public class UserDeleteViewModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Id { get; set; }
	}
}
