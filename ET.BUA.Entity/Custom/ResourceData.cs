using System;

namespace ET.BUA.Entity.Custom
{
    public interface IResourceData
    {
        object Code
        {
            get;
            set;
        }

        object Name
        {
            get;
            set;
        }
    }

    [Serializable]
    public class ResourceData : IResourceData
    {
        private string _Code = null;

        private string _Name = null;

        public object Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                this._Code = Convert.ToString(value);
            }
        }

        public object Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = Convert.ToString(value);
            }
        }
    }
}
