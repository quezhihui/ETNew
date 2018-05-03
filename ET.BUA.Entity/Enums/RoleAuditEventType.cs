using System;

namespace ET.BUA.Entity.Enums
{
    [Serializable]
    public enum RoleAuditEventType
    {
        RemoveRoleOrg,
        RemoveRolePost,
        RemoveRoleUser,
        AddRoleOrg,
        AddRolePost,
        AddRoleUser,
        RemovePostUser,
        RemoveOrgUser,
        AddPostUser,
        AddOrgUser,
        RemoveAttrPrivilege,
        GrantPrivilegesToRole
    }
}
