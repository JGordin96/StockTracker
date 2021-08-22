using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockTracker.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Ticker { get; set; }
    }
}