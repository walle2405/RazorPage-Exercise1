﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
	public interface ICategoryRepository
	{
		IEnumerable<Category> GetAll();
		void Add(Category category);
		void Update(Category category);
		bool Remove(Category category);
	}
}
