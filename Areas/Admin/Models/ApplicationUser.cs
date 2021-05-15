using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppWithAdmin.Areas.Admin.Models
{
	public class ApplicationUser : BaseModel
	{
		[Required(ErrorMessage ="Please enter your first name")]
		[Display(Name = "first name")]
		[DataType(DataType.Text)]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Please enter your last name")]
		[Display(Name = "last name")]
		[DataType(DataType.Text)]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Please enter your email address")]
		[Display(Name ="email address")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required(ErrorMessage = "Please select a user role")]
		[Display(Name ="user role")]
		[DataType(DataType.Text)]
		public string Role { get; set; }

		public ICollection<Post> Posts { get; set; }
	}
}
