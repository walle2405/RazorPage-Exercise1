using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
	public interface IOrderRepository
	{
		IEnumerable<Order> GetAll();
		void Add(Order order);
		void Update(Order order);
		bool Remove(Order order);
	}
}
