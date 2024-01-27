using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
	public interface ICustomerRepository
	{
		IEnumerable<Customer> GetAll();
		void Add(Customer customer);
		void Update(Customer customer);
		bool Remove(Customer customer);
	}
}
