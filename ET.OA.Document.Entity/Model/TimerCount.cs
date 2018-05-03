using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class TimerCount
    {
        public int Id { get; set; }
        public string ProjectId { get; set; }
        public int? Taskid { get; set; }
        public string FormDocument { get; set; }
        public string Wenh { get; set; }
        public DateTime? DocDate { get; set; }
        public string CurrentLocation { get; set; }
        public string TimeOver { get; set; }
        public string IsSend { get; set; }
        public DateTime? IntertTime { get; set; }
        public string Chulirenuid { get; set; }
        public string Chuliren { get; set; }
        public string IssuedTime { get; set; }
        public string Unitid { get; set; }
        public string Unitname { get; set; }
    }
}
