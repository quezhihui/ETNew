using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreBizTableManageMaintenanceBusinessTableLog
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string ObjectName { get; set; }
        public string ObjectDesc { get; set; }
        public string CreatorId { get; set; }
        public string CreatorName { get; set; }
        public string CreatorDeptId { get; set; }
        public string CreatorDeptName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string LastUpdateManId { get; set; }
        public string LastUpdateManName { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? OperType { get; set; }
        public int? Status { get; set; }
        public int Sequence { get; set; }
        public int TableDelete { get; set; }
    }
}
