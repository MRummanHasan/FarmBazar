using FarmBazar.Entities;
using FarmBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmBazar.Web.Controllers
{
    public class CategoryController : Controller
    {
		CategoriesService categoryService = new CategoriesService();

		// GET: Category
		[HttpGet]
		public ActionResult Index()
		{
			var categories = categoryService.GetCategories();
			return View(categories);
		}

		//To show view-of-create Categories
		[HttpGet]
        public ActionResult Create()
        {
            return View();
        }
		//To create category
		[HttpPost]
		public ActionResult Create(Category category)
		{
			categoryService.SaveCategory(category);
			return RedirectToAction("Index");
		}


		//To show EDIT Categories
		[HttpGet]
		public ActionResult Edit(int ID)
		{
			//get categories from db
			var categories = categoryService.GetCategory(ID);
			return View(categories);
		}
		//To edit/update Categories
		[HttpPost]
		public ActionResult Edit(Category category)
		{
			categoryService.UpdateCategory(category);
			return RedirectToAction("Index");
		}


		//To show DELETE Categories
		[HttpGet]
		public ActionResult Delete(int ID)
		{
			//get categories from db
			var category = categoryService.GetCategory(ID);
			return View(category);
		}
		//To delete Category
		[HttpPost] 
		public ActionResult Delete(Category category)
		{
			categoryService.DeleteCategory(category.ID);
			return RedirectToAction("Index");
		}
	}
}