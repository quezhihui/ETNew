using ET.BUA.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ET.BUA.Entity.Custom
{
    [Serializable]
    public class AllUserInfo
    {
        private UserEntity _User;

        private BUA_USER_PERSON _UserPerson;

        private BUA_USER_OFFICE _UserOffice;

        private IList<BUA_USER_EX> _UserExSetList;

        public UserEntity User
        {
            get
            {
                return this._User;
            }
            set
            {
                this._User = value;
            }
        }

        public BUA_USER_PERSON UserPerson
        {
            get
            {
                return this._UserPerson;
            }
            set
            {
                this._UserPerson = value;
            }
        }

        public BUA_USER_OFFICE UserOffice
        {
            get
            {
                return this._UserOffice;
            }
            set
            {
                this._UserOffice = value;
            }
        }

        [XmlIgnore]
        public IList<BUA_USER_EX> UserExSetList
        {
            get
            {
                return this._UserExSetList;
            }
            set
            {
                this._UserExSetList = value;
            }
        }
    }
}
