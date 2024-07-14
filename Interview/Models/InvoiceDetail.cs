using System;
using System.Collections.Generic;

namespace Interview.Models;

public partial class InvoiceDetail
{
    public int LineNo { get; set; }

    public string? ProductName { get; set; }

    public int? UnitNo { get; set; }

    public decimal? Price { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Total { get; set; }

    public DateTime? ExpiryDate { get; set; }

  
}
