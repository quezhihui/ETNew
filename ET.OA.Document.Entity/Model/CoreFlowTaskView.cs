using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFlowTaskView
    {
        public int Id { get; set; }
        public int? TaskId { get; set; }
        public DateTime? ViewTime { get; set; }
        public string ViewUserUid { get; set; }
        public string ViewUserName { get; set; }
    }
}
