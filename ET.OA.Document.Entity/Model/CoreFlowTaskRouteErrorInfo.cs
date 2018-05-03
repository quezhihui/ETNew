using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFlowTaskRouteErrorInfo
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? TaskId { get; set; }
        public string Title { get; set; }
        public string TempLateTableId { get; set; }
        public string ParentTitle { get; set; }
        public string ParentTempLateTableId { get; set; }
        public int? FlowId { get; set; }
        public string FlowName { get; set; }
        public int? NodeId { get; set; }
        public string NodeName { get; set; }
        public int? NodeType { get; set; }
        public int? MultiMode { get; set; }
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
        public string OperationUserIds { get; set; }
        public string OperationUserNames { get; set; }
        public string OperationGroupIds { get; set; }
        public string OperationGroupNames { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public DateTime? Createtime { get; set; }
        public string PreHandlerId { get; set; }
        public string PreHandlerName { get; set; }
        public string HandlerAssigned { get; set; }
        public string HandlerId { get; set; }
        public string HandlerName { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? IsTemporary { get; set; }
        public int? IsHang { get; set; }
        public DateTime? HangStartTime { get; set; }
        public DateTime? HangEndTime { get; set; }
        public int? Sequence { get; set; }
        public int? IsVisible { get; set; }
        public string ParentFlowName { get; set; }
        public string ParentFlowNodeName { get; set; }
        public string HangUserCode { get; set; }
        public string HangUserName { get; set; }
        public string TemporaryUserCode { get; set; }
        public string TemporaryUserName { get; set; }
        public int? FlowIsVisible { get; set; }
        public int? FlowIsDelete { get; set; }
        public DateTime? RouteCreatetime { get; set; }
        public string RouteCreatorId { get; set; }
        public string RouteCreatorName { get; set; }
        public string RouteOperator { get; set; }
        public string RouteOperatorName { get; set; }
        public DateTime? RouteUpdateTime { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorMethod { get; set; }
        public int? ErrorIsDelete { get; set; }
        public string ErrorDeptId { get; set; }
        public string ErrorDeptName { get; set; }
        public string ErrorUnitId { get; set; }
        public string ErrorUnitName { get; set; }
        public int? IsProcess { get; set; }
    }
}
