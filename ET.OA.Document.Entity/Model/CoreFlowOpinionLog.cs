using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFlowOpinionLog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? ProjectId { get; set; }
        public string UserName { get; set; }
        public string UserUid { get; set; }
        public string UserOrgCode { get; set; }
        public string UserUnitCode { get; set; }
        public string UserOrgName { get; set; }
        public string UserUnitName { get; set; }
        public int? CurrentNodeId { get; set; }
        public string CurrentNodeName { get; set; }
        public string CurrentFlowId { get; set; }
        public string CurrentFlowName { get; set; }
        public int? TaskId { get; set; }
        public string OldOpinion { get; set; }
        public string Opinion { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
