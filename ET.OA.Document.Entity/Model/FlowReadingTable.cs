using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class FlowReadingTable
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? TaskId { get; set; }
        public string Title { get; set; }
        public string Reasons { get; set; }
        public int? IsOpen { get; set; }
        public int? Num { get; set; }
        public int? Readed { get; set; }
        public string ReadUserCodes { get; set; }
        public string ReadUserNames { get; set; }
        public string CreatorName { get; set; }
        public string CreatorId { get; set; }
        public string OrgName { get; set; }
        public string OrgId { get; set; }
        public string UnitName { get; set; }
        public string UnitId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateUserId { get; set; }
        public int? IsDelete { get; set; }
    }
}
