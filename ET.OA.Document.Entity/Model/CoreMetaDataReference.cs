using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreMetaDataReference
    {
        public int Id { get; set; }
        public string ReferenceCode { get; set; }
        public string ParentTableCode { get; set; }
        public string ParentColumnCode { get; set; }
        public string ChildTableCode { get; set; }
        public string ChildColumnCode { get; set; }
        public string ReferenceType { get; set; }
    }
}
