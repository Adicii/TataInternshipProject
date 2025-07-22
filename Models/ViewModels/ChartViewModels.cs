using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductApp.Models.ViewModels
{
    public class MetricValueGroupViewModel
    {
        public string Category { get; set; }
        public double Value { get; set; }
    }

    public class ScatterPointViewModel
    {
        public int X { get; set; } 
        public int Y { get; set; } 
        public string Label { get; set; }
    }
}
