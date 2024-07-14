using System;
using System.Collections.Generic;

namespace Interview.Models;

public partial class Unit
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual InvoiceDetail? InvoiceDetail { get; set; }
}
