using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class FlowExtensionInfoTable
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public string Title { get; set; }
        public string CreatorName { get; set; }
        public string CreatorId { get; set; }
        public string OrgName { get; set; }
        public string OrgId { get; set; }
        public string UnitName { get; set; }
        public string UnitId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ParentTaskId { get; set; }
        public int? ParentNodeId { get; set; }
        public string ParentNodeName { get; set; }
        public int? ParentNodeType { get; set; }
        public string NodeName { get; set; }
        public string NodeId { get; set; }
        public string OperatorName { get; set; }
        public string OperatorId { get; set; }
        public int? FlowId { get; set; }
        public string FlowName { get; set; }
        public string PreviousUserName { get; set; }
        public string PreviousUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string UpdateUserName { get; set; }
        public string UpdateUserId { get; set; }
        public int? IsDelete { get; set; }
    }
}
