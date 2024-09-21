using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTools.Models
{
    public class AnalysisModel
    {
        public IList<string> Names { get; set; }
        public IList<string> Common { get; set; }
        public IList<string> Unique { get; set; }

        public AnalysisModel()
        {
            Common = new List<string>();
            Unique = new List<string>();
            Names = new List<string>();
        }
    }
}
