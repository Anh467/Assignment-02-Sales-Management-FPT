﻿using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Orderr
{
    public int OrderId { get; set; }

    public int MemberId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public decimal? Frieght { get; set; }

    public virtual Member Member { get; set; } = null!;
}
