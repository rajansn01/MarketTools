using DailyTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static DailyTools.IndexConstants;
using static DailyTools.Constants;
using DailyTools.Interface;

namespace DailyTools.Services
{
    public class IndexService : IIndexService
    {
       
        private List<IndexModel> IndexModels;

        public IndexService()
        {
            IndexModels = new List<IndexModel>();
            IndexModels.Add(new IndexModel { IndexFileName = GetFilePath(INDEX_DATA_ROOT_DIR, NIFTY_SMALLCAP_50), IndexName = "NIFTY_SMALLCAP_50" });
            IndexModels.Add(new IndexModel { IndexFileName = GetFilePath(INDEX_DATA_ROOT_DIR, NIFTY_SMALLCAP_100), IndexName = "NIFTY_SMALLCAP_100" });
            IndexModels.Add(new IndexModel { IndexFileName = GetFilePath(INDEX_DATA_ROOT_DIR, NIFTY_SMALLCAP_250), IndexName = "NIFTY_SMALLCAP_250" });
            PopulateIndexData();
        }

        private void PopulateIndexData()
        {
            foreach (var indexModel in IndexModels)
            {
                string fileFullPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), indexModel.IndexFileName);
                var lines = File.ReadAllLines(fileFullPath);

                foreach (var line in lines)
                {
                    indexModel.StockNames.Add(line.Trim());
                }
            }
        }

        public bool IsSmallCap(string stockName)
        {
            foreach (var indexModel in IndexModels)
            {
                foreach (var sourceName in indexModel.StockNames)
                {
                    if(IsStockEqual(sourceName, stockName))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool IsStockEqual(string sourceName, string toName)
        {
            var sourceNameLower = sourceName.ToLower();
            var toNameLower = toName.ToLower();

            return sourceNameLower.StartsWith(toNameLower);
        }
    }
}
