using ET.BUA.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ET.BUA.Entity.Custom
{
    [Serializable]
    public class TreeData
    {
        private string _Id;

        private string _ParentId;

        private string _Value;

        private string _Name;

        private TreeNodeType _NodeType;

        private string _AppId = "";

        private DisplayState _State;

        private string _DataId = "";

        private TreeNodeType _DataType;

        private bool _HasChildData = true;

        private bool _IsSelected = false;

        private IList<TreeData> _ChildTreeData = new List<TreeData>();

        private TreeType _TreeType;

        public string Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = value;
            }
        }

        public string ParentId
        {
            get
            {
                return this._ParentId;
            }
            set
            {
                this._ParentId = value;
            }
        }

        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this._Value = value;
            }
        }

        public TreeNodeType NodeType
        {
            get
            {
                return this._NodeType;
            }
            set
            {
                this._NodeType = value;
            }
        }

        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        }

        public DisplayState State
        {
            get
            {
                return this._State;
            }
            set
            {
                this._State = value;
            }
        }

        public string AppId
        {
            get
            {
                return this._AppId;
            }
            set
            {
                this._AppId = value;
            }
        }

        public string DataId
        {
            get
            {
                return this._DataId;
            }
            set
            {
                this._DataId = value;
            }
        }

        public TreeNodeType DataType
        {
            get
            {
                return this._DataType;
            }
            set
            {
                this._DataType = value;
            }
        }

        public TreeType TreeType
        {
            get
            {
                return this._TreeType;
            }
            set
            {
                this._TreeType = value;
            }
        }

        public bool IsSelected
        {
            get
            {
                return this._IsSelected;
            }
            set
            {
                this._IsSelected = value;
            }
        }

        public bool HasChildData
        {
            get
            {
                return this._HasChildData;
            }
            set
            {
                this._HasChildData = value;
            }
        }

        [XmlIgnore]
        public IList<TreeData> ChildTreeData
        {
            get
            {
                return this._ChildTreeData;
            }
            set
            {
                this._ChildTreeData = value;
            }
        }
    }
}
