using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity.Model
{
    public partial class CoreAttachment
    {
        public int Id { get; set; }
        public string RefTableId { get; set; }
        public string RefTableName { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string RelativePath { get; set; }
        public string InternalName { get; set; }
        public string ContentType { get; set; }
        public int? Length { get; set; }
        public byte[] Content { get; set; }
        public int? TypeCode { get; set; }
        public int? PersistentType { get; set; }
        public string CreatorId { get; set; }
        public string CreatorName { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? Sequence { get; set; }
        public int? IsDelete { get; set; }
    }
}
