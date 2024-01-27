using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class OrderDetailDAO
	{
		FuflowerBouquetManagementV4Context _context;
		DbSet<OrderDetail> _dbSet;

		public OrderDetailDAO(FuflowerBouquetManagementV4Context context)
		{
			_context = context;
			_dbSet = _context.Set<OrderDetail>();
		}

		public List<OrderDetail> GetOrderDetails()
		{
			return _context.OrderDetails.ToList();
		}

		public OrderDetail GetOrderDetailById(int id)
		{
			return _context.OrderDetails.Find(id);
		}

		public void AddOrderDetail(OrderDetail orderDetail)
		{
			_context.OrderDetails.Add(orderDetail);
			_context.SaveChanges();
		}

		public void UpdateOrderDetail(OrderDetail orderDetail)
		{
			var tracker = _context.Attach(orderDetail);
			tracker.State = EntityState.Modified;
			_context.SaveChanges();
		}

		public bool DeleteOrderDetail(OrderDetail orderDetail)
		{
			try
			{
				_dbSet.Remove(orderDetail);
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
