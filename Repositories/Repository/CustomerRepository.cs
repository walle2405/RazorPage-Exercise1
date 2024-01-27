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
	public class CustomerRepository : ICustomerRepository
	{
		CustomerDAO _customerDAO;
		public CustomerRepository(CustomerDAO customerDAO)
		{
			_customerDAO = customerDAO;
		}
		public void Add(Customer customer)
		{
			_customerDAO.AddCustomer(customer);
		}

		public IEnumerable<Customer> GetAll()
		{
			return _customerDAO.GetCustomers();
		}

		public bool Remove(Customer customer)
		{
			return _customerDAO.DeleteCustomer(customer);
		}

		public void Update(Customer customer)
		{
			_customerDAO.UpdateCustomer(customer);
		}
	}
}
