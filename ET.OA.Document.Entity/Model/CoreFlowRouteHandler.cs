using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFlowRouteHandler
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dllname { get; set; }
        public string NameSpace { get; set; }
        public string ClassName { get; set; }
        public string FunctionName { get; set; }
        public int? Sequence { get; set; }
        public int? TypeHandler { get; set; }
        public int? IsShare { get; set; }
        public string BaseFlowIds { get; set; }
        public string CreatorId { get; set; }
        public string CreatorName { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? IsDelete { get; set; }
    }
}
