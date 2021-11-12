using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Saskatoon.ViewModels;

namespace Municipality.Model
{
    public class AverageVm
    {
        public TotalVm Total { get; set; }
        public IEnumerable<HitVm> Hits { get; set; }
    }
}
