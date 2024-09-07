using System;
using System.Collections.Generic;

namespace WebAPIWithEFState.Models;

public partial class ProductType
{
    public int ProductTypeId { get; set; }

    public string? TypeName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
