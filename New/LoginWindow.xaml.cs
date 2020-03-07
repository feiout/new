using System.Windows;
using System.Windows.Input;
using New.RestUtility;
using New.Service;
using New.ViewModels;

namespace New
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly UserService _userService = ServiceHelper<UserService>.CreateInterface();
        private VmUser _vm;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_OnLoaded(object sender, RoutedEventArgs e)
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

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if(_vm==null)return;
            _vm.User.userlogin.loginName= UserName.Text.Trim();
            _vm.User.userlogin.password = Password.Password.Trim();

            _vm.User = _userService.Authentication(_vm.User);
            if (string.Equals(_vm.User.status, "Error"))
            {
                MessageBox.Show(@"Logon failed");
            }
            else
            {
                var mainWindow = new MainWindow(_vm.User);
                mainWindow.Show();
                this.Close();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();

        }

        private void LoginWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)DragMove();

        }
    }
}
