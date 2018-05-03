using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreParameters
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CorrelationId { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DateCreated { get; set; }
        public string LastModifiedUser { get; set; }
        public DateTime? DateLastModified { get; set; }
        public int? Sequence { get; set; }
    }
}
