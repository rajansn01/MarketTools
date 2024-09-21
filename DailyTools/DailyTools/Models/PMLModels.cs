using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTools.Models
{
    public class CreatedBy
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class DataPML
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public CreatedBy CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public ModifiedBy ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public object ExternalId { get; set; }
        public string BundleId { get; set; }
        public string PriceListId { get; set; }
        public string ConfigurationType { get; set; }
        public string OrgId { get; set; }
        public string LibraryObjectId { get; set; }
        public string ProductGroupIds { get; set; }
        public string ProductFamilyIds { get; set; }
        public int LibraryObjectSize { get; set; }
        public string ETag { get; set; }
        public object IsPreCompiled { get; set; }
        public object ModelVersion { get; set; }
    }

    public class ModifiedBy
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class PMLRoot
    {
        public bool Success { get; set; }
        public List<DataPML> Data { get; set; }
        public string Profile { get; set; }
        public double TotalTime { get; set; }
        public string StatusCode { get; set; }
    }
}
