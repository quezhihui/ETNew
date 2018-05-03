using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFlowProject
    {
        public int Id { get; set; }
        public int? FlowId { get; set; }
        public string FlowName { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? TemplateId { get; set; }
        public int? Status { get; set; }
        public int? ParentProjectId { get; set; }
        public int? ParentTemplateId { get; set; }
        public int? ParentFlowId { get; set; }
        public int? ParentFlowNodeId { get; set; }
        public int? ParentTaskId { get; set; }
        public string ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string CreatorId { get; set; }
        public string CreatorName { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public int? Sequence { get; set; }
        public int? IsDelete { get; set; }
        public string ParentFlowNodeName { get; set; }
        public string ParentFlowName { get; set; }
        public string Title { get; set; }
        public string ParentTitle { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string OperatorName { get; set; }
        public string Operator { get; set; }
    }
}
