using System;

namespace ET.BUA.Entity.Enums
{
    [Serializable]
    public enum ObjectType
    {
        None,
        User,
        Post,
        Org,
        App,
        Role,
        Privilege,
        AttrPrivilege,
        AttrGroupPrivilege,
        Dic
    }
}
