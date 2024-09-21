using DailyTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTools
{
    internal interface IMutualFundService
    {
        void SectorDisplay(IList<MutualFund> mutualFunds);
        void ProcessETSmallStockMoneyData();
        void ProcessETInfrastructureStockMoneyData();
        void GenerateData();
    }
}
