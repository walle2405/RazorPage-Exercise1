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
	public class OrderDetailRepository : IOrderDetailRepository
	{
		OrderDetailDAO _orderDetailDAO;

		public OrderDetailRepository(OrderDetailDAO orderDetailDAO)
		{
			_orderDetailDAO = orderDetailDAO;
		}
		public void Add(OrderDetail orderDetail)
		{
			_orderDetailDAO.AddOrderDetail(orderDetail);
		}

		public IEnumerable<OrderDetail> GetAll()
		{
			return _orderDetailDAO.GetOrderDetails();
		}

		public bool Remove(OrderDetail orderDetail)
		{
			return _orderDetailDAO.DeleteOrderDetail(orderDetail);
		}

		public void Update(OrderDetail orderDetail)
		{
			_orderDetailDAO.UpdateOrderDetail(orderDetail);
		}
	}
}
