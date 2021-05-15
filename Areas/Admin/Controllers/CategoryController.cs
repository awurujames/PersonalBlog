using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithAdmin.Areas.Admin.Models;
using WebAppWithAdmin.Areas.Admin.Repository;
using WebAppWithAdmin.Areas.Admin.ViewModels;

namespace WebAppWithAdmin.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class CategoryController : Controller
	{
		private readonly ICategoryRepository _categoryRepository;
		public CategoryController(ICategoryRepository catetoryRepository)
		{
			_categoryRepository = catetoryRepository;
		}
		public IActionResult Index()
		{
			var categories = _categoryRepository.GetAll();
			var model = new CategoryIndexViewModel { Categories = categories };
			return View(model);
		}
		[HttpGet]
		public IActionResult Add()
		{
			var model = new CategoryAddViewModel();
			return View(model);
		}

		[HttpPost]
		public IActionResult Add(CategoryAddViewModel model)
		{
			if (!ModelState.IsValid)
				return View(model);

			var category = new Category
			{
				CategoryName = model.CategoryName
			};

			_categoryRepository.AddCategory(category);

			model.StatusMessage = "New category added successfully!";

			return View(model);
		}
	}
}
