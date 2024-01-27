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
	public class OrderRepository : IOrderRepository
	{
		OrderDAO _orderDAO;
		public OrderRepository(OrderDAO orderDAO)
		{
			_orderDAO = orderDAO;
		}
		public void Add(Order order)
		{
			_orderDAO.AddOrder(order);
		}

		public IEnumerable<Order> GetAll()
		{
			return _orderDAO.GetOrders();
		}

		public bool Remove(Order order)
		{
			return _orderDAO.DeleteOrder(order);
		}

		public void Update(Order order)
		{
			_orderDAO.UpdateOrder(order);
		}
	}
}
