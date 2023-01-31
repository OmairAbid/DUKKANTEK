using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUKKANTEK.Inventory.Application.Features.Commands.Basket;
public class AddProductToBasketCommand: IRequest<BasicResponse>
{
    public string? BillingAddress { get; set; }
    public string? ShippingAddress { get; set; }
    public int ProductId { get; set; }
}
