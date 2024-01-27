using BusinessObjects;
using DataAccessLayer;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
	public class CategoryRepository : ICategoryRepository
	{
		CategoryDAO _categoryDAO;
		public CategoryRepository(CategoryDAO categoryDAO)
		{
			_categoryDAO = categoryDAO;
		}
		public void Add(Category category)
		{
			_categoryDAO.AddCategory(category);
		}

		public IEnumerable<Category> GetAll()
		{
			return _categoryDAO.GetCategories();
		}

		public bool Remove(Category category)
		{
			return _categoryDAO.DeleteCategory(category);
		}

		public void Update(Category category)
		{
			_categoryDAO.UpdateCategory(category);
		}
	}
}
