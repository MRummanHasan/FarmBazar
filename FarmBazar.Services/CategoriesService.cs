using FarmBazar.Database;
using FarmBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmBazar.Services
{
	//Service project to deal Service in FarmBazar.
	
	//extra class to handle services realted to Category
	public class CategoriesService
	{
		//get single category to edit
		public Category GetCategory(int ID)
		{
			using (var context = new FBContext())
			{
				return context.Categories.Find(ID);
			}
		}
		public List<Category> GetCategories()
		{
			using (var context = new FBContext())
			{
				return context.Categories.ToList();
			}
		}
		public void SaveCategory(Category category)
		{
			using (var context = new FBContext())
			{
				context.Categories.Add(category);
				context.SaveChanges();
			}	 
		}

		public void UpdateCategory(Category category)
		{
			using (var context = new FBContext())
			{
				context.Entry(category).State = System.Data.Entity.EntityState.Modified;
				context.SaveChanges();
			}
		}

		public void DeleteCategory(int ID)
		{
			using (var context = new FBContext())
			{
				//context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
				var category = context.Categories.Find(ID);
				context.Categories.Remove(category);
				context.SaveChanges();
			}
		}
	}
}
