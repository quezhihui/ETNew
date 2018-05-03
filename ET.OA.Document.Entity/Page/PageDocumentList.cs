using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ET.OA.Document.Entity.Page
{
    public class PageDocumentList
    {
        [Key]
        public int ProjectID { get; set; }

        public int TemplateID { get; set; }

        public int ProjectStatus { get; set; }

        public int TaskID { get; set; }

        public string FlowName { get; set; }

        public DateTime ProjectCreatetime { get; set; }

        public string Title { get; set; }

        public int NodeID { get; set; }

        public string NodeName { get; set; }

        public string OperationUserNames { get; set; }
    }
}
