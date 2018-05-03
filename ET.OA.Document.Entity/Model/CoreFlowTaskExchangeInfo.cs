using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFlowTaskExchangeInfo
    {
        public int Id { get; set; }
        public int? ParentProjectId { get; set; }
        public string Title { get; set; }
        public int ChangeId { get; set; }
        public int? FromFlowId { get; set; }
        public int? ToFlowId { get; set; }
        public string CreatorUser { get; set; }
        public string CreatorUserName { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ChangeOpinion { get; set; }
        public string ApprovalOpinion { get; set; }
        public string ApprovalUser { get; set; }
        public string ApprovalUserName { get; set; }
        public int? NowProjectId { get; set; }
        public int? AcceptStatus { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }
        public string OtherMsg { get; set; }
        public int? IsDelete { get; set; }
        public int? Sequence { get; set; }
        public string AcceptUnitId { get; set; }
        public string AcceptUnitName { get; set; }
        public string ChangeType { get; set; }
        public int? TypeDemo { get; set; }
        public int? ReadCount { get; set; }
        public string CreateUnitId { get; set; }
        public string CreateUnitName { get; set; }
        public string ExceptionMsg { get; set; }
        public int? ActionType { get; set; }
    }
}
