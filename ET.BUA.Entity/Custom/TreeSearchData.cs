using System;

namespace ET.BUA.Entity.Custom
{
    [Serializable]
    public class TreeSearchData
    {
        private string _SearchType;

        private string _SearchName;

        public string SearchType
        {
            get
            {
                return this._SearchType;
            }
            set
            {
                this._SearchType = value;
            }
        }

        public string SearchName
        {
            get
            {
                return this._SearchName;
            }
            set
            {
                this._SearchName = value;
            }
        }
    }
}
