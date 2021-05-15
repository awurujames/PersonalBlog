 using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Models;

namespace WebAppWithAdmin.Areas.Admin.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
				
		}

		public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
