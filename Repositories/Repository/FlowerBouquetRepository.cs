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
	public class FlowerBouquetRepository : IFlowerBouquetRepository
	{
		FlowerBouquetDAO _flowerBouquetDAO;
		public FlowerBouquetRepository(FlowerBouquetDAO flowerBouquetDAO)
		{
			_flowerBouquetDAO = flowerBouquetDAO;
		}
		public void Add(FlowerBouquet flowerBouquet)
		{
			_flowerBouquetDAO.AddFlowerBouquet(flowerBouquet);
		}

		public IEnumerable<FlowerBouquet> GetAll()
		{
			return _flowerBouquetDAO.GetFlowerBouquets();
		}

		public bool Remove(FlowerBouquet flowerBouquet)
		{
			return _flowerBouquetDAO.DeleteFlowerBouquet(flowerBouquet);
		}

		public void Update(FlowerBouquet flowerBouquet)
		{
			_flowerBouquetDAO.UpdateFlowerBouquet(flowerBouquet);
		}
	}
}
