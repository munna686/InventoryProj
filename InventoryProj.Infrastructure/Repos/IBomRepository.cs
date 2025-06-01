using InvenotryProj.Core.Interfaces;
using InvenotryProj.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProj.Infrastructure.Repos
{
    public class BomRepository : GenericRepository<BomMaster>,IBomRepository
    {
        public BomRepository(InventoryDataContext context) : base(context) { }
    }
}
