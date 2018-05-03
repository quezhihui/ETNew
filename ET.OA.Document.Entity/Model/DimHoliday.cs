using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class DimHoliday
    {
        public int Id { get; set; }
        public DateTime? Holiday { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
    }
}
