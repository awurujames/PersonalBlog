using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Repository;
using WebAppWithAdmin.Areas.Admin.ViewModels;

namespace WebAppWithAdmin.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ManageController : Controller
	{
		private IUserRepository userRepository;
		public ManageController(IUserRepository userRepository)
		{
			this.userRepository = userRepository;
		}
		[HttpGet]
		public IActionResult Index()
		{
			var users = userRepository.GetAllUsers();
			return View(users);
		}

		[HttpGet]
		public IActionResult Add()
		{
			var viewModel = new UserAddViewModel();
			return View(viewModel);
		}

		[HttpPost]
		public IActionResult Add(UserAddViewModel viewModel)
		{

			return View();
		}
	}
}
