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
	public class SupplierRepository : ISupplierRepository
	{
		SupplierDAO _supplierDAO;

		public SupplierRepository(SupplierDAO supplierDAO)
		{
			_supplierDAO = supplierDAO;
		}
		public void Add(Supplier supplier)
		{
			_supplierDAO.AddSupplier(supplier);
		}

		public IEnumerable<Supplier> GetAll()
		{
			return _supplierDAO.GetSuppliers();
		}

		public bool Remove(Supplier supplier)
		{
			return _supplierDAO.DeleteSupplier(supplier);
		}

		public void Update(Supplier supplier)
		{
			_supplierDAO.UpdateSupplier(supplier);
		}
	}
}
