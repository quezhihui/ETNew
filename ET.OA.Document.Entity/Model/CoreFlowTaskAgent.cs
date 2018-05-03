using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFlowTaskAgent
    {
        public int Id { get; set; }
        public string ModuleId { get; set; }
        public string ModuleName { get; set; }
        public int? FlowId { get; set; }
        public string FlowName { get; set; }
        public string ConsignerId { get; set; }
        public string ConsignerName { get; set; }
        public string AgentId { get; set; }
        public string AgentName { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? IsEnd { get; set; }
        public string CreatorId { get; set; }
        public string CreatorName { get; set; }
        public int? AgentType { get; set; }
        public DateTime? AgentEndTime { get; set; }
        public string Description { get; set; }
        public string GroupId { get; set; }
        public int? TaskAgentCount { get; set; }
    }
}
