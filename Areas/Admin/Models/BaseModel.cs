using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppWithAdmin.Areas.Admin.Models
{
	public class BaseModel
	{
		[Key]
		public int Id { get; set; }
		public DateTimeOffset? DateCreated { get; set; }
		public DateTimeOffset? DateModified { get; set; }
	}
}
