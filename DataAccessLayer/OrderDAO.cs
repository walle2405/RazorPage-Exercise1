using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class OrderDAO
	{
		FuflowerBouquetManagementV4Context _context;
		DbSet<Order> _dbSet;

		public OrderDAO(FuflowerBouquetManagementV4Context context)
		{
			_context = context;
			_dbSet = _context.Set<Order>();
		}

		public List<Order> GetOrders()
		{
			return _context.Orders.ToList();
		}

		public Order GetOrderById(int id)
		{
			return _context.Orders.Find(id);
		}

		public void AddOrder(Order order)
		{
			_context.Orders.Add(order);
			_context.SaveChanges();
		}

		public void UpdateOrder(Order order)
		{
			var tracker = _context.Attach(order);
			tracker.State = EntityState.Modified;
			_context.SaveChanges();
		}

		public bool DeleteOrder(Order order)
		{
			try
			{
				_dbSet.Remove(order);
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
