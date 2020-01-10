using System;
using System.Windows;
using New.Base;
using New.RestUtility;
using New.Service;
using New.ViewModels;

namespace New.Views.Main
{

    public partial class TaskList
    {
        private readonly UserService _userService = ServiceHelper<UserService>.CreateInterface();
        private VmTask _vm;
        public TaskList()
        {
            InitializeComponent();
        }

        private void UserName_OnClick(object sender, RoutedEventArgs e)
        {
//            Button btn = sender as Button;
//            string id = btn.Tag.ToString();
//            string content = btn.Content.ToString();
//            SessionBase.Path = "/" + content;
//            var newEventArgs = new RoutedEventArgs(MyEvent, content);
//            RaiseEvent(newEventArgs);
        }

        private void TaskList_OnInitializedList_OnInitialized(object sender, EventArgs e)
        {
            if (DataContext == null)
            {
                _vm = new VmTask();
                DataContext = _vm;
            }
            else
            {
                _vm = DataContext as VmTask;
            }
//            _vm.UserList = _userService.GetUserList();
            
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            SessionBase.Path = "/CreateCase";
            var newEventArgs = new RoutedEventArgs(MyEvent, "id");
            RaiseEvent(newEventArgs);

        }
    }
}
