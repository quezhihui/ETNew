using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class FlowReadUserTable
    {
        public int Id { get; set; }
        public int? ReadId { get; set; }
        public int? ProjectId { get; set; }
        public int? TaskId { get; set; }
        public string Title { get; set; }
        public string Reasons { get; set; }
        public int? IsRead { get; set; }
        public string CreatorName { get; set; }
        public string CreatorId { get; set; }
        public string OrgName { get; set; }
        public string OrgId { get; set; }
        public string UnitName { get; set; }
        public string UnitId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? IsDelete { get; set; }
    }
}
