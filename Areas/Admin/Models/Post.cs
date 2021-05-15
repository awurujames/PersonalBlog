using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppWithAdmin.Areas.Admin.Models
{
	public class Post : BaseModel
	{
		[Required]
		public string Title { get; set; }
		[Required]
		public string Body { get; set; }
		[RegularExpression(@"^https?:.+$")]
		public string ImageUrl { get; set; } = "https://picserio.com/data/out/10/images-of-new-wallpapers_2353442.jpg";

        internal static object Take(int v)
        {
            throw new NotImplementedException();
        }

        [Required]
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		[Required]
		public int ApplicationUserId { get; set; }
		public ApplicationUser ApplicationUser { get; set; }


	}
}
