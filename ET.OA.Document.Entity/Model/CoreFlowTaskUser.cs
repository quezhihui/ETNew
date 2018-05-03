using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFlowTaskUser
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? FlowId { get; set; }
        public string FlowName { get; set; }
        public int? NodeId { get; set; }
        public string NodeName { get; set; }
        public int? TemplateId { get; set; }
        public int? TaskStatus { get; set; }
        public int? ParentProjectId { get; set; }
        public int? ParentTemplateId { get; set; }
        public int? ParentFlowId { get; set; }
        public int? ParentFlowNodeId { get; set; }
        public string ParentFlowName { get; set; }
        public string ParentFlowNodeName { get; set; }
        public int? ParentTaskId { get; set; }
        public string ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string CreatorId { get; set; }
        public string CreatorName { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public DateTime? Createtime { get; set; }
        public int? TaskId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string AgentId { get; set; }
        public string AgentName { get; set; }
        public int? Sequence { get; set; }
        public string Title { get; set; }
        public int? IsVisible { get; set; }
    }
}
