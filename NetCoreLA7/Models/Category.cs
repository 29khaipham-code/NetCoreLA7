using System;
using System.Collections.Generic;

namespace NetCoreLA7.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte? Status { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
