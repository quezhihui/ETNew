using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFlowNodeHandler
    {
        public int Id { get; set; }
        public int FlowId { get; set; }
        public int? NodeId { get; set; }
        public string HandlerId { get; set; }
        public string HandlerName { get; set; }
        public string GroupdId { get; set; }
        public string GroupName { get; set; }
        public int? TemplateId { get; set; }
        public int? Sequence { get; set; }
        public string NodeName { get; set; }
        public int? NodeType { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public int? IsAllUser { get; set; }
        public string HandlerDeptCode { get; set; }
        public string HandlerDeptName { get; set; }
        public string HandlerUnitCode { get; set; }
        public string HandlerUnitName { get; set; }
    }
}
