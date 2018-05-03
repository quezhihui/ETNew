using System;

namespace ET.BUA.Entity.Enums
{
    [Serializable]
    public enum UserAuditEventType
    {
        InsertUser,
        UpdateUser,
        DeleteUser,
        Lock,
        Unlock,
        UpdatePassword,
        ResetPassword,
        SetMasterOrg
    }
}
