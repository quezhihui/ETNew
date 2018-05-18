using System;
namespace ET.BUA.Domain
{
    public class BUATableNames : IBUATableNames
    {
        public BUATableNames()
        {

        }
        public string TablePrefix { get; set; } = "BUA_";

        public string ApplicationTableName { get; set; } = "APPLICATION";

        public string UserTableName { get; set; } = "USER";
    }
}
