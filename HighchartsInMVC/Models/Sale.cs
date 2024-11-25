using System;
using System.Collections.Generic;

namespace HighchartsInMVC.Models;

public partial class Sale
{
    public int Id { get; set; }

    public string? Months { get; set; }

    public int? SalesAmount { get; set; }
}
