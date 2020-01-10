using New.Common;

namespace New.Entity
{
    public class User_login : NotificationObject
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

        private string _userId;
        public string userId
        {
            get { return _userId; }
            set
            {
                if (_userId != value)
                {
                    _userId = value;
                    RaisePropertyChanged("userId");
                }
            }
        }

        private string _loginName;
        public string loginName
        {
            get { return _loginName; }
            set
            {
                if (_loginName != value)
                {
                    _loginName = value;
                    RaisePropertyChanged("loginName");
                }
            }
        }

        private string _password;
        public string password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    RaisePropertyChanged("password");
                }
            }
        }

    }
}
