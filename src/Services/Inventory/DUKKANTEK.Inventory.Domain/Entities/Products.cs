using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUKKANTEK.Inventory.Domain.Entities;
public class Products : EntityBase
{
    public string? Name { get; set; }
    [Column(TypeName = "char")]
    public string? Barcode { get; set; }
    public string? Description { get; set; }
    public string? CategoryName { get; set; }
    public bool IsWeighted { get; set; }
    public int ProductStatus { get; set; }
}
