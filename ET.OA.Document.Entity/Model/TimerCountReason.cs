using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class TimerCountReason
    {
        public int Id { get; set; }
        public int? Taskid { get; set; }
        public int? ProjectId { get; set; }
        public string Reason { get; set; }
        public DateTime? Createdate { get; set; }
        public string Creator { get; set; }
        public string Creatoruid { get; set; }
        public int? IsDelete { get; set; }
    }
}
