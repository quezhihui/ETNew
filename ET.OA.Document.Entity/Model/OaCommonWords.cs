using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class OaCommonWords
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string UserName { get; set; }
        public string UserUid { get; set; }
        public string UserOrgCode { get; set; }
        public string UserUnitCode { get; set; }
        public string UserOrgName { get; set; }
        public string UserUnitName { get; set; }
        public string Content { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? IsPublic { get; set; }
    }
}
