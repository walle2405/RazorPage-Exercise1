using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
	public interface ISupplierRepository
	{
		IEnumerable<Supplier> GetAll();
		void Add(Supplier supplier);
		void Update(Supplier supplier);
		bool Remove(Supplier supplier);
	}
}
