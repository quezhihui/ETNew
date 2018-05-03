using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFormTemplate
    {
        public int Id { get; set; }
        public string ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string CreatorId { get; set; }
        public string CreatorName { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public int? IsAllowShare { get; set; }
        public string FlowRootAppCode { get; set; }
        public string FlowRootAppName { get; set; }
        public string Name { get; set; }
        public string BizTableName { get; set; }
        public string FormHtml { get; set; }
        public string FormMobileHtml { get; set; }
        public string FormPadHtml { get; set; }
        public string FormPrintHtml { get; set; }
        public string ImgName { get; set; }
        public byte[] Image { get; set; }
        public int? Sequence { get; set; }
        public string Description { get; set; }
        public string FormUrl { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateUserCode { get; set; }
        public string UpDateUserName { get; set; }
        public int? IsDelete { get; set; }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
    }
}
