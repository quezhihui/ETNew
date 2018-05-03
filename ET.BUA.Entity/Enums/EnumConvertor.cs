using System;

namespace ET.BUA.Entity.Enums
{
    [Serializable]
    public static class EnumConvertor
    {
        public static ExSetType GetExSetTypeFromString(string s)
        {
            ExSetType result;
            if (s != null)
            {
                if (s == "ORG")
                {
                    result = ExSetType.OrgEx;
                    return result;
                }
            }
            result = ExSetType.None;
            return result;
        }

        public static string ConvertExSetToString(ExSetType type)
        {
            string result;
            switch (type)
            {
                case ExSetType.OrgEx:
                    result = "ORG";
                    break;
                case ExSetType.UserEx:
                    result = "User";
                    break;
                default:
                    result = "None";
                    break;
            }
            return result;
        }

        public static OrgAreaLevel GetOrgAreaLevelFromValue(int level)
        {
            OrgAreaLevel result;
            switch (level)
            {
                case 1:
                    result = OrgAreaLevel.AllOrg;
                    break;
                case 2:
                    result = OrgAreaLevel.CurrentUnit;
                    break;
                case 3:
                    result = OrgAreaLevel.CurrentOrg;
                    break;
                case 4:
                    result = OrgAreaLevel.OrgTree;
                    break;
                default:
                    result = OrgAreaLevel.None;
                    break;
            }
            return result;
        }

        public static string GetRoleTypeName(string roleType)
        {
            string text = roleType.ToUpper();
            string result;
            if (text != null)
            {
                if (text == "S")
                {
                    result = "系统角色";
                    return result;
                }
                if (text == "P")
                {
                    result = "私有角色";
                    return result;
                }
                if (text == "B")
                {
                    result = "业务角色";
                    return result;
                }
            }
            result = "";
            return result;
        }
    }
}
