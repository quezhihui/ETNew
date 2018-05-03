using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFlowMain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? FormTemplateId { get; set; }
        public string FlowDesignXml { get; set; }
        public string Description { get; set; }
        public string ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string CreatorId { get; set; }
        public string CreatorName { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public int? BaseFlowId { get; set; }
        public int? Version { get; set; }
        public int? IsSubFlow { get; set; }
        public int? IsAllowShare { get; set; }
        public int? IsVisible { get; set; }
        public int? IsDelete { get; set; }
        public string FlowRootAppCode { get; set; }
        public string FlowRootAppName { get; set; }
        public int? IsCommon { get; set; }
        public string CommonModule { get; set; }
        public string CommonModuleId { get; set; }
        public DateTime? Createtime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? Sequence { get; set; }
        public string DeptPathIndex { get; set; }
        public string ImgUrl { get; set; }
        public string SortCode { get; set; }
        public string SortName { get; set; }
        public string SendOrgCode { get; set; }
        public string SendOrgName { get; set; }
        public int? IsMobile { get; set; }
    }
}
