using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class CustomerDAO
	{
		// generate similar to CategoryDAO
		FuflowerBouquetManagementV4Context _context;
		DbSet<Customer> _dbSet;

		public CustomerDAO(FuflowerBouquetManagementV4Context context)
		{
			_context = context;
			_dbSet = _context.Set<Customer>();
		}

		public List<Customer> GetCustomers()
		{
			return _context.Customers.ToList();
		}

		public Customer GetCustomerById(int id)
		{
			return _context.Customers.Find(id);
		}

		public void AddCustomer(Customer customer)
		{
			_context.Customers.Add(customer);
			_context.SaveChanges();
		}

		public void UpdateCustomer(Customer customer)
		{
			var tracker = _context.Attach(customer);
			tracker.State = EntityState.Modified;
			_context.SaveChanges();
		}

		public bool DeleteCustomer(Customer customer)
		{
			try
			{
				_dbSet.Remove(customer);
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
