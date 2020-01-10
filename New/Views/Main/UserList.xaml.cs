using System;
using System.Windows;
using System.Windows.Controls;
using New.Base;
using New.RestUtility;
using New.Service;
using New.ViewModels;

namespace New.Views.Main
{
    public partial class UserList
    {
        private readonly UserService _userService = ServiceHelper<UserService>.CreateInterface();
        private VmUser _vm;
        private int _loadedTimes = 0;
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_OnInitialized(object sender, EventArgs e)
        {
            if (DataContext == null)
            {
                _vm = new VmUser();
                DataContext = _vm;
            }
            else
            {
                _vm = DataContext as VmUser;
            }
            if (_loadedTimes > 0)
            {
                return;
            }
            _vm.UserList = _userService.GetUserList();
            _loadedTimes++;
        }

        private void UserName_OnClick(object sender, RoutedEventArgs e)
        {
            Button btn=sender as Button;
            string id = btn.Tag.ToString();
            string content = btn.Content.ToString();
            SessionBase.Path = "/"+content;
            var newEventArgs=new RoutedEventArgs(MyEvent, id);
            RaiseEvent(newEventArgs);
//            MessageBox.Show(SessionBase.User.department);
        }

    }
}
