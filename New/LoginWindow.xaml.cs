using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using New.Entity;
using New.RestUtility;
using New.Service;

namespace New
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly UserService _userService = ServiceHelper<UserService>.CreateInterface();
        public LoginWindow()
        {
            InitializeComponent();
        }


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            User user=new User();
            user.userlogin = new Userlogin();
            user.userlogin.loginName= UserName.Text.Trim();
            user.userlogin.password = Password.Password.Trim();

            user=_userService.Authentication(user);
//            if (user == null)
            if (string.Equals(user.status, "Error"))
            {
                MessageBox.Show(@"Logon failed");
            }
            else
            {
                var mainWindow = new MainWindow(user);
                mainWindow.Show();
                this.Close();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();

        }
    }
}
