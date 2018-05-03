using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFormTemplateDoc
    {
        public int Id { get; set; }
        public int? TemplateId { get; set; }
        public int? Type { get; set; }
        public int? AttchId { get; set; }
        public string Description { get; set; }
        public string CreatorId { get; set; }
        public string CreatorName { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public int? IsDelete { get; set; }
        public int? Sequence { get; set; }
        public string TemplateName { get; set; }
        public string Name { get; set; }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
    }
}
