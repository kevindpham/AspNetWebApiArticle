﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class PortfolioItem
{
    public int Id { get; set; }

    [StringLength(10)]
    public string Symbol { get; set; }

    public decimal Qty { get; set; }
    public decimal ItemValue { get; set; }

    [StringLength(50)]
    public string Company { get; set; }

    public decimal LastPrice { get; set; }
    public decimal OpenPrice { get; set; }
    public decimal NetChange { get; set; }

    public DateTime QuoteTime { get; set; }

    [ForeignKey("User")]
    public int? UserId { get; set; }
    public User User { get; set; }

}