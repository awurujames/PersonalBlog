using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppWithAdmin.Areas.Admin.Repository;
using WebAppWithAdmin.Models;
using WebAppWithAdmin.ViewModels;

namespace WebAppWithAdmin.Controllers
{
	public class HomeController : Controller
	{
		private readonly IPostRepository _postRepository;

		public HomeController(IPostRepository postRepository)
		{
			_postRepository = postRepository;
		}

		public IActionResult Index()
		{
			var viewModel = new HomeIndexViewModel { Posts = _postRepository.GetAll() };
			return View(viewModel);
		}
		
		public IActionResult Post(int Id)
		{
			if (Id == 0)
				return NotFound();

			var post = _postRepository.GetPost(Id);

			if (post == null)
				return NotFound();

			var viewModel = new HomePostViewModel();

			viewModel.Author = post.ApplicationUser.FirstName + " " + post.ApplicationUser.LastName;
			viewModel.Body = post.Body;
			viewModel.Title = post.Title;
			viewModel.Category = post.Category.CategoryName;
			viewModel.ImageURL = post.ImageUrl;

			return View(viewModel);
		}

		
	}
}
