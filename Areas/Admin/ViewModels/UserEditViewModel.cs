using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppWithAdmin.Areas.Admin.ViewModels
{
	public class UserEditViewModel
	{
		public int Id { get; set; }
		[Required]
		[Display(Name = "first name")]
		public string FirstName { get; set; }
		[Required]
		[Display(Name = "last name")]
		public string LastName { get; set; }
		[Required]
		[Display(Name = "email address")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required]
		[Display(Name = "user role")]
		public string Role { get; set; }
		public string StatusMessage { get; set; }
	}
}
