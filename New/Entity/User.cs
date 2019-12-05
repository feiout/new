

using New.Common;

namespace New.Entity
{
    public class User : NotificationObject
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged("id");
                }
            }
        }

        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged("name");
                }
            }
        }

        private string _department;
        public string department
        {
            get { return _department; }
            set
            {
                if (_department != value)
                {
                    _department = value;
                    RaisePropertyChanged("department");
                }
            }
        }

        private string _userType;
        public string userType
        {
            get { return _userType; }
            set
            {
                if (_userType != value)
                {
                    _userType = value;
                    RaisePropertyChanged("userType");
                }
            }
        }

        private int _subscriptionId;
        public int subscriptionId
        {
            get { return _subscriptionId; }
            set
            {
                if (_subscriptionId != value)
                {
                    _subscriptionId = value;
                    RaisePropertyChanged("subscriptionId");
                }
            }
        }

        private Userlogin _userlogin;
        public Userlogin userlogin
        {
            get { return _userlogin; }
            set
            {
                if (_userlogin != value)
                {
                    _userlogin = value;
                    RaisePropertyChanged("userlogin");
                }
            }
        }

        private string _status;
        public string status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged("status");
                }
            }
        }

    }
}
