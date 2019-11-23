﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetForever.Web.Models;

namespace DotNetForever.Web.ViewModels
{
    public class SaleReportViewModel
    {
        public string Code { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public int SoldQty { get; set; }
        public double CP { get; set; }
        public double MRP { get; set; }
        public double Profit { get; set; }
    }
}