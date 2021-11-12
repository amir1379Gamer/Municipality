using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Saskatoon.ViewModels
{
    public class RootVm
    {
        public TotalVm total { get; set; }
        public List<HitVm> hits { get; set; }
    }
}