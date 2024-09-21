using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTools.Models
{
    public class ETRawDataModel
    {
        public int TotalLines { get; set; }

        public int ProcessedLines { get; set; }

        public int UnProcessedLines { get; set; }
        public IList<string> UnProcessedDataLines { get; set; }

        public IDictionary<string, IList<string>> SectorSegregate { get; set; }

        public ETRawDataModel()
        {
            UnProcessedDataLines = new List<string>();
            SectorSegregate = new Dictionary<string, IList<string>>(); ;
        }
    }
}
