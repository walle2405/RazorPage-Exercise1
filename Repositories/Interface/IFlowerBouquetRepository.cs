using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
	public interface IFlowerBouquetRepository
	{
		IEnumerable<FlowerBouquet> GetAll();
		void Add(FlowerBouquet flowerBouquet);
		void Update(FlowerBouquet flowerBouquet);
		bool Remove(FlowerBouquet flowerBouquet);
	}
}
