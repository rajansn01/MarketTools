using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTools.Models
{
    public class IndexModel
    {
        public string IndexName { get; set; }
        public string IndexFileName { get; set; }
        public List<string> StockNames { get; set; }

        public IndexModel()
        {
            StockNames = new List<string>();
        }
    }
}
