﻿using System;

namespace ET.BUA.Entity.Enums
{
    [Serializable]
    public enum RolePriorLevel
    {
        AllOrg = 1,
        CurrentUnit,
        CurrentOrg,
        OrgTree,
        None = 9
    }
}
