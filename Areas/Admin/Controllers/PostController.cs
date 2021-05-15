using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using WebAppWithAdmin.Areas.Admin.Models;
using WebAppWithAdmin.Areas.Admin.Repository;
using WebAppWithAdmin.Areas.Admin.ViewModels;

namespace WebAppWithAdmin.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class PostController : Controller
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly IUserRepository _userRepository;
		private readonly IPostRepository _postRepository;
		private readonly IWebHostEnvironment webHostEnvironment;

		public PostController(
			ICategoryRepository categoryRepository, 
			IUserRepository userRepository, 
			IPostRepository postRepository,
			IWebHostEnvironment webHostEnvironment)
		{
			_categoryRepository = categoryRepository;
			_userRepository = userRepository;
			_postRepository = postRepository;
			this.webHostEnvironment = webHostEnvironment;
		}
		public IActionResult Index()
		{

			var viewModel = new PostIndexViewModel { Posts = _postRepository.GetAll() };
			//var newModwl = new PostIndexViewModel();
			return View(viewModel);
		}

		[HttpGet]
		public IActionResult Add()
		{
			var viewModel = PopulateDropDown();

			return View(viewModel);
		}

		[HttpPost]
		public IActionResult Add(PostAddViewModel viewModel)
		{
			if (!ModelState.IsValid)
				return View(viewModel); 

			var post = new Post
			{
				Title = viewModel.Title,
				Body = viewModel.Body,
				CategoryId = viewModel.CategoryId,
				ApplicationUserId = viewModel.ApplicationUserId,
				ImageUrl = GetImageFilePath(viewModel.ImageUpload)
			};

			var result = _postRepository.AddPost(post);

			if (result == true)
				TempData["StatusMessage"] = "Post added successfully!";
			else
				ModelState.AddModelError(string.Empty, "Oops, something went wrong, please try again!");

			return RedirectToAction("Add");
		}

		[NonAction]
		public PostAddViewModel PopulateDropDown()
		{
			var viewModel = new PostAddViewModel();
			var categories = _categoryRepository.GetAll();
			var users = _userRepository.GetAllUsers();

			viewModel.Categories = categories;
			viewModel.Users = users;

			return viewModel;
		}

		[NonAction]
		public string GetImageFilePath(IFormFile ImageUpload)
		{
			string uniqueFileName = null;

			if(ImageUpload != null)
			{
				var uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "uploads");
				uniqueFileName = Guid.NewGuid().ToString() + "-" + ImageUpload.FileName;
				var ImageFilePath = Path.Combine(uploadsFolder, uniqueFileName);

				using (var fileStream = new FileStream(ImageFilePath, FileMode.Create))
				{
					ImageUpload.CopyTo(fileStream);
				}
			}
			return uniqueFileName;

		}


		[HttpGet]
		public IActionResult Edit(int Id)
		{
			if (Id == 0)
				return NotFound();

			var post = _postRepository.GetPost(Id);

			var viewModel = new PostEditViewModel();
			

			return View(viewModel);
		}

		[HttpPost]
		public IActionResult Edit(PostEditViewModel model)
		{
			if (!ModelState.IsValid)
				return View(model);

			var post = new Post();
			

			var result = _postRepository.UpdatePost(post);

			if (result == true)
				model.StatusMessage = "User account updated successfully!";
			else
				ModelState.AddModelError(string.Empty, "Sorry, something went wrong!");

			return View(model);
		}


	}
}
