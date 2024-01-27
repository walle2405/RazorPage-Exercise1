using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class FlowerBouquetDAO
	{
		FuflowerBouquetManagementV4Context _context;
		DbSet<FlowerBouquet> _dbSet;

		public FlowerBouquetDAO(FuflowerBouquetManagementV4Context context)
		{
			_context = context;
			_dbSet = _context.Set<FlowerBouquet>();
		}

		public List<FlowerBouquet> GetFlowerBouquets()
		{
			return _context.FlowerBouquets.ToList();
		}

		public FlowerBouquet GetFlowerBouquetById(int id)
		{
			return _context.FlowerBouquets.Find(id);
		}

		public void AddFlowerBouquet(FlowerBouquet flowerBouquet)
		{
			_context.FlowerBouquets.Add(flowerBouquet);
			_context.SaveChanges();
		}

		public void UpdateFlowerBouquet(FlowerBouquet flowerBouquet)
		{
			var tracker = _context.Attach(flowerBouquet);
			tracker.State = EntityState.Modified;
			_context.SaveChanges();
		}

		public bool DeleteFlowerBouquet(FlowerBouquet flowerBouquet)
		{
			try
			{
				_dbSet.Remove(flowerBouquet);
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
