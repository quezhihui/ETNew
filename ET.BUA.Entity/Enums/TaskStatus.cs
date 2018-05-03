using System;

namespace ET.BUA.Entity.Enums
{
    [Serializable]
    public enum TaskStatus
    {
        None,
        New,
        FailedAndContinue,
        Fail,
        Success
    }
}
