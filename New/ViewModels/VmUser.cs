using System.Collections.Generic;
using System.Collections.ObjectModel;
using New.Base;
using New.Entity;
using New.RestUtility;
using New.Service;


namespace New.ViewModels
{
    public class VmUser : ViewModelBase
    {
        private readonly UserService _userService = ServiceHelper<UserService>.CreateInterface();
        public List<KeyValuePair<string, string>> Conditions = new List<KeyValuePair<string, string>>();

        public VmUser()
        {
            User = new User();
            User.userlogin = new User_login();
        }


        private ObservableCollection<User> _userList;
        public ObservableCollection<User> UserList
        {
            get { return _userList; }
            set
            {
                if (_userList != value)
                {
                    _userList = value;
                    RaisePropertyChanged("UserList");
                }
            }
        }

        private User _User;
        public User User
        {
            get { return _User; }
            set
            {
                if (_User != value)
                {
                    _User = value;
                    RaisePropertyChanged("User");
                }
            }
        }

    }
}
