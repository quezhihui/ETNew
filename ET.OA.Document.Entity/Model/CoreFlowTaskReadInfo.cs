using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFlowTaskReadInfo
    {
        public int Id { get; set; }
        public int? TaskId { get; set; }
        public string PassUserId { get; set; }
        public string PassUserName { get; set; }
        public string ReadUserId { get; set; }
        public string ReadUserName { get; set; }
        public string Opinions { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? IsRead { get; set; }
        public int? Sequence { get; set; }
        public string Title { get; set; }
        public string ModuleId { get; set; }
        public string ModuleName { get; set; }
        public int? ProjectId { get; set; }
        public string Message { get; set; }
    }
}
