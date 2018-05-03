using System;

namespace ET.BUA.Entity.Model
{
    [Serializable]
    public class UserSequence
    {
        private string _UserId;

        private string _UserUid;

        private int _MasterFlag;

        private int _Sequence;

        public string UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                this._UserId = value;
            }
        }

        public string UserUid
        {
            get
            {
                return this._UserUid;
            }
            set
            {
                this._UserUid = value;
            }
        }

        public int MasterFlag
        {
            get
            {
                return this._MasterFlag;
            }
            set
            {
                this._MasterFlag = value;
            }
        }

        public int Sequence
        {
            get
            {
                return this._Sequence;
            }
            set
            {
                this._Sequence = value;
            }
        }
    }
}
