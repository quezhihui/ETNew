using System;

namespace ET.BUA.Entity.Enums
{
    [Serializable]
    public enum AuditEventType
    {
        UserAuditEvent,
        DelObjectAuditEvent,
        RoleAuditEvent,
        LoginAuditEvent
    }
}
