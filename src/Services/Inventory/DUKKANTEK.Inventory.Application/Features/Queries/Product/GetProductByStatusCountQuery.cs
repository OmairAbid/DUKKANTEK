using DUKKANTEK.Inventory.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUKKANTEK.Inventory.Application.Features.Queries.Product;
public class GetProductByStatusCountQuery : IRequest<BasicResponse<ProductStatusCountResponse>>
{
}
