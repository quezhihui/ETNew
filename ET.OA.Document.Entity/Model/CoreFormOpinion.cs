using System;
using System.Collections.Generic;

namespace ET.OA.Document.Entity
{
    public partial class CoreFormOpinion
    {
        public int Id { get; set; }
        public string Opinion { get; set; }
        public string Creator { get; set; }
        public string CreateName { get; set; }
        public string UpdateUser { get; set; }
        public string UpdateUserName { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
