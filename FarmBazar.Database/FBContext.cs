using FarmBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmBazar.Database
{
	public class FBContext : DbContext
	{
		public FBContext(): base("FarmBazarConnection")
		{

		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }

	}
}
