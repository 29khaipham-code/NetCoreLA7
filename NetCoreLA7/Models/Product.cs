using System;
using System.Collections.Generic;

namespace NetCoreLA7.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public double? SalePrice { get; set; }

    public byte? Status { get; set; }

    public int CategoryId { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }

    public virtual Category Category { get; set; } = null!;
}
