using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ET.OA.Document.Entity.Model
{
    [Serializable]
    public class UserInfo
    {
        public string UserUID { get; set; }

        public string UserName { get; set; }

        public string OrgCode { get; set; }

        public string OrgName { get; set; }

        public string UnitCode { get; set; }

        public string UnitName { get; set; }
    }
}