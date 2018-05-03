using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFlowNode
    {
        public int Id { get; set; }
        public int FlowId { get; set; }
        public int? NodeId { get; set; }
        public string Name { get; set; }
        public int? NodeType { get; set; }
        public int? IsAutoTurning { get; set; }
        public string NodeHandlers { get; set; }
        public int? ResTimeType { get; set; }
        public int? ResTimeNum { get; set; }
        public int? RetNodeId { get; set; }
        public int? NextNodeId { get; set; }
        public int? IsDetach { get; set; }
        public string LayoutInfo { get; set; }
        public int? SubFlowId { get; set; }
        public int? IsSelfTemplate { get; set; }
        public int? SelfTemplateId { get; set; }
        public string Description { get; set; }
        public int? Sequence { get; set; }
        public int? LogicMode { get; set; }
        public string SubFlowName { get; set; }
        public int? MultiMode { get; set; }
        public int? FilterId { get; set; }
        public string FilterName { get; set; }
        public int? ProcessType { get; set; }
        public int? AgainstNum { get; set; }
        public int? RejectNodeId { get; set; }
        public string OpinionTable { get; set; }
        public string OpinionColumn { get; set; }
        public string MatchContent { get; set; }
        public string TaskIdcolumn { get; set; }
        public int? VoteType { get; set; }
        public double? AgainstRating { get; set; }
    }
}
