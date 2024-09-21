using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTools.Models
{
    public class MutualFund
    {
        public string Name { get; set; }
        public string FileName { get; set; }
        public IList<Stock> Stocks { get; set; }
        public ETRawDataModel RawDataModel { get; set; }
    }
}
