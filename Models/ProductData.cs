using System;
using System.Collections.Generic;

namespace WebAPIWithEFState.Models;

public class ProductData:Product
{
    public string TypeName { get; set; } = null!;
}
