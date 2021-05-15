using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Models;

namespace WebAppWithAdmin.Areas.Admin.ViewModels
{
	public class PostAddViewModel
	{
		public PostAddViewModel()
		{
			Categories = new List<Category>();
			Users = new List<ApplicationUser>();
		}
		[Required(ErrorMessage = "Post must have a title")]
		[StringLength(100, MinimumLength = 5)]
		[DataType(DataType.Text)]
		public string Title { get; set; }

		[Required(ErrorMessage = "Post must have a body")]
		[DataType(DataType.MultilineText)]
		[MinLength(100)]
		public string Body { get; set; }

		[Required(ErrorMessage ="Please select post image")]
		public IFormFile ImageUpload { get; set; }

		[Required(ErrorMessage ="You must select a post category")]
		public int CategoryId { get; set; }

		[Required(ErrorMessage = "You must select a post author")]
		public int ApplicationUserId { get; set; }

		public IEnumerable<Category> Categories { get; set; }

		public IEnumerable<ApplicationUser> Users { get; set; }

		public string StatusMessage { get; set; }
	}
}
