using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class SupplierDAO
	{
		FuflowerBouquetManagementV4Context _context;
		DbSet<Supplier> _dbSet;

		public SupplierDAO(FuflowerBouquetManagementV4Context context)
		{
			_context = context;
			_dbSet = _context.Set<Supplier>();
		}

		public List<Supplier> GetSuppliers()
		{
			return _context.Suppliers.ToList();
		}

		public Supplier GetSupplierById(int id)
		{
			return _context.Suppliers.Find(id);
		}

		public void AddSupplier(Supplier supplier)
		{
			_context.Suppliers.Add(supplier);
			_context.SaveChanges();
		}

		public void UpdateSupplier(Supplier supplier)
		{
			var tracker = _context.Attach(supplier);
			tracker.State = EntityState.Modified;
			_context.SaveChanges();
		}

		public bool DeleteSupplier(Supplier supplier)
		{
			try
			{
				_dbSet.Remove(supplier);
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
