using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTools.Models
{
    public class Stock
    {
        public string CompanyName { get; set; }

        public string Sector { get; set; }

        public string HoldingPercent { get; set; }

        public IList<string> FundNames { get; set; }

        public Stock()
        {
            FundNames = new List<string>();
        }
    }
}
