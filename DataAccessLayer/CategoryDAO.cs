using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class CategoryDAO
	{
		FuflowerBouquetManagementV4Context _context;
		DbSet<Category> _dbSet;

		public CategoryDAO(FuflowerBouquetManagementV4Context context)
		{
			_context = context;
			_dbSet = _context.Set<Category>();
		}

		public List<Category> GetCategories()
		{
			return _context.Categories.ToList();
		}

		public Category GetCategoryById(int id)
		{
			return _context.Categories.Find(id);
		}

		public void AddCategory(Category category)
		{
			_context.Categories.Add(category);
			_context.SaveChanges();
		}

		public void UpdateCategory(Category category)
		{
			var tracker = _context.Attach(category);
			tracker.State = EntityState.Modified;
			_context.SaveChanges();
		}

		public bool DeleteCategory(Category category)
		{
			try
			{
				_dbSet.Remove(category);
				_context.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
