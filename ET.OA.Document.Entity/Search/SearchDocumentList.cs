using ET.OA.Document.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ET.OA.Document.Entity.Search
{
    public class SearchDocumentList
    {
        public string Title { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int ProjectStatus { get; set; }

        public string FlowName { get; set; }

        public string ProjectCreatorName { get; set; }

        public bool ShowChild { get; set; }

        public SearchType SearchType { get; set; }

    }
}
