using DUKKANTEK.Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUKKANTEK.Inventory.Application.Features.Queries.Product;
public class ProductStatusCountResponse
{
    public Dictionary<ProductStatus, int> ProductStatus { get; set; }
}
