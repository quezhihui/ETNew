using System;

namespace ET.BUA.Entity.Custom
{
    [Serializable]
    public class TreeParameter
    {
        private TreeData _TreeData;

        private TreeSearchData _SearchData;

        private string _OperatedDataId;

        public TreeData ParentTreeData
        {
            get
            {
                return this._TreeData;
            }
            set
            {
                this._TreeData = value;
            }
        }

        public TreeSearchData SearchData
        {
            get
            {
                return this._SearchData;
            }
            set
            {
                this._SearchData = value;
            }
        }

        public string OperatedDataId
        {
            get
            {
                return this._OperatedDataId;
            }
            set
            {
                this._OperatedDataId = value;
            }
        }
    }
}
