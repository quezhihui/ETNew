using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFlowDirection
    {
        public int Id { get; set; }
        public int? FlowId { get; set; }
        public int? DirectionId { get; set; }
        public int? PrevNodeId { get; set; }
        public int? NextNodeId { get; set; }
        public int? ConstraintMode { get; set; }
        public string Constraint { get; set; }
        public int? KeepMode { get; set; }
        public int? KeepNodeId { get; set; }
        public string LayoutInfo { get; set; }
        public int? Sequence { get; set; }
    }
}
