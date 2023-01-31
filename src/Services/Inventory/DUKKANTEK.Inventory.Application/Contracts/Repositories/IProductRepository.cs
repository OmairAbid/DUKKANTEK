using DUKKANTEK.Inventory.Domain.Entities;
using DUKKANTEK.Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUKKANTEK.Inventory.Application.Contracts.Repositories;
public interface IProductRepository:IAsyncRepository<Products>
{
    Task<Dictionary<ProductStatus, int>> GetProductsByStatusCount();
}
