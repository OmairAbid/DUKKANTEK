using DUKKANTEK.Inventory.Application.Models;
using DUKKANTEK.Inventory.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUKKANTEK.Inventory.Application.Features.Commands.Product.Update;
public class UpdateStatusCommand : IRequest<BasicResponse<int>>
{
    public int ProductId { get; set; }
    public ProductStatus ProductStatus { get; set; }
}
