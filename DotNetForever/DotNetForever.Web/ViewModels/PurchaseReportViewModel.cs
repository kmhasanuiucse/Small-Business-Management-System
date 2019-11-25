﻿

using System;
using System.Collections.Generic;

namespace DotNetForever.Web.ViewModels
{
    public class PurchaseReportViewModel
    {
        public string Code { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public int AvailableQty { get; set; }
        public double CP { get; set; }
        public double MRP { get; set; }
        public double Profit { get; set; }

        public static explicit operator PurchaseReportViewModel(List<PurchaseReport> v)
        {
            throw new NotImplementedException();
        }
    }
}