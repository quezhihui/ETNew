using System;

namespace ET.BUA.Entity.Enums
{
    [Serializable]
    public enum AuditObjectType
    {
        USER,
        POST,
        ORG,
        APP,
        ROLE,
        PRIVILEGE,
        ATTR
    }
}
