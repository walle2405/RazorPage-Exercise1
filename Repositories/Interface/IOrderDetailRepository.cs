using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
	public interface IOrderDetailRepository
	{
		IEnumerable<OrderDetail> GetAll();
		void Add(OrderDetail orderDetail);
		void Update(OrderDetail orderDetail);
		bool Remove(OrderDetail orderDetail);
	}
}
