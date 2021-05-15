using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppWithAdmin.ViewModels
{
	public class HomePostViewModel
	{
		public string Title { get; set; }
		public string Body { get; set; }
		public string Author { get; set; }
		public string Category { get; set; }
		public string ImageURL { get; set; }
	}
}
