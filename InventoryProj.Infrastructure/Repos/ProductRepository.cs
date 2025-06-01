using InvenotryProj.Core.Interfaces;
using InvenotryProj.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProj.Infrastructure.Repos
{
    public class ProductRepository : GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(InventoryDataContext context) : base(context) { }
    }
}
