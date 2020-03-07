using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using New.Base;
using New.Entity;
using New.ViewModels;
using New.Views.Case;
using New.Views.Main;
using Company = New.Views.Main.CompanyList;
using Customer = New.Views.Main.CustomerList;

namespace New
{

    public partial class MainWindow : Window
    {
        private Dictionary<String, UserControl> controls = new Dictionary<string, UserControl>();
        Color color = Color.FromRgb(159, 168, 218);
        Color color2 = (Color) ColorConverter.ConvertFromString("Transparent");
        SolidColorBrush brush;
        SolidColorBrush brush2;
//        private VmCreateCase _vm;

        public MainWindow(User user)
        {
            InitializeComponent();
            SessionBase.User = user;
            controls.Add("/TaskList", new TaskList());
            controls.Add("/CaseList", new CaseList());
            controls.Add("/CustomerList", new CustomerList());
            controls.Add("/CompanyList", new CompanyList());
            controls.Add("/CreateCase", new CreateCase());

        }

        private void Window_Load(object sender, RoutedEventArgs e)
        {
//            SessionBase.Path = "/tasklist";
//            Cccc_evtCallArrive();
        }

        private void HandleChineEvent(object sender, RoutedEventArgs e)
        {
            SessionBase.Paras = e.OriginalSource.ToString();
            CoreRouter();
            //            Cccc_evtCallArrive();
        }

//
//        private void Cccc_evtCallArrive()
//        {
//            SolidColorBrush brush = new SolidColorBrush(color);
//            SolidColorBrush brush2 = new SolidColorBrush(color2);
//            if (!controls.ContainsKey(SessionBase.Path)) return;
//            var content = controls[SessionBase.Path];
//            switch (SessionBase.Path)
//            {
//                case "/CreateCase":
//                    TransparentSet();
////                    _vm.QueryDicData();
//                    Display.Content = content;
//                    break;
//                case "/tasklist":
//                    CallList.Background = brush;
//                    CaseList.Background = brush2;
//                    LeadList.Background = brush2;
//                    Opportunity.Background = brush2;
//                    Customer.Background = brush2;
//                    Company.Background = brush2;
//                    UserList.Background = brush2;
//                    Display.Content = content;
//                    break;
//                case "/caselist":
//                    CallList.Background = brush2;
//                    CaseList.Background = brush;
//                    LeadList.Background = brush2;
//                    Opportunity.Background = brush2;
//                    Customer.Background = brush2;
//                    Company.Background = brush2;
//                    UserList.Background = brush2;
//                    Display.Content = content;
//                    break;
//                case "/leadlist":
//                    CallList.Background = brush2;
//                    CaseList.Background = brush2;
//                    LeadList.Background = brush;
//                    Opportunity.Background = brush2;
//                    Customer.Background = brush2;
//                    Company.Background = brush2;
//                    UserList.Background = brush2;
//                    Display.Content = content;
//                    break;
//                case "/opportunity":
//                    CallList.Background = brush2;
//                    CaseList.Background = brush2;
//                    LeadList.Background = brush2;
//                    Opportunity.Background = brush;
//                    Customer.Background = brush2;
//                    Company.Background = brush2;
//                    UserList.Background = brush2;
//                    Display.Content = content;
//                    break;
//                case "/customer":
//                    CallList.Background = brush2;
//                    CaseList.Background = brush2;
//                    LeadList.Background = brush2;
//                    Opportunity.Background = brush2;
//                    Customer.Background = brush;
//                    Company.Background = brush2;
//                    UserList.Background = brush2;
//                    Display.Content = content;
//                    break;
//                case "/company":
//                    CallList.Background = brush2;
//                    CaseList.Background = brush2;
//                    LeadList.Background = brush2;
//                    Opportunity.Background = brush2;
//                    Customer.Background = brush2;
//                    Company.Background = brush;
//                    UserList.Background = brush2;
//                    Display.Content = content;
//                    break;
//                case "/userlist":
//                    CallList.Background = brush2;
//                    CaseList.Background = brush2;
//                    LeadList.Background = brush2;
//                    Opportunity.Background = brush2;
//                    Customer.Background = brush2;
//                    Company.Background = brush2;
//                    UserList.Background = brush;
//                    Display.Content = content;
//                    break;
//                case "/Messi":
//                    TransparentSet();
//                    Display.Content = content;
//                    break;
//                default:
//                    CallList.Background = brush;
//                    CaseList.Background = brush2;
//                    LeadList.Background = brush2;
//                    Opportunity.Background = brush2;
//                    Customer.Background = brush2;
//                    Company.Background = brush2;
//                    UserList.Background = brush2;
//                    Display.Content = content;
//                    break;
//            }
//        }
//
//        private void TransparentSet()
//        {
//            SolidColorBrush brush2 = new SolidColorBrush(color2);
//            CallList.Background = brush2;
//            CaseList.Background = brush2;
//            LeadList.Background = brush2;
//            Opportunity.Background = brush2;
//            Customer.Background = brush2;
//            Company.Background = brush2;
//            UserList.Background = brush2;
//        }

        //private void CallList_OnClick(object sender, RoutedEventArgs e)
        //{
        //    SessionBase.Path = "/tasklist";
        //    Cccc_evtCallArrive();
        //}

        //private void CaseList_OnClick(object sender, RoutedEventArgs e)
        //{
        //    SessionBase.Path = "/caselist";
        //    Cccc_evtCallArrive();
        //}

        //private void LeadList_OnClick(object sender, RoutedEventArgs e)
        //{
        //    SessionBase.Path = "/leadlist";
        //    Cccc_evtCallArrive();
        //}

        //private void Opportunity_OnClick(object sender, RoutedEventArgs e)
        //{
        //    SessionBase.Path = "/opportunity";
        //    Cccc_evtCallArrive();
        //}

        //private void Customer_OnClick(object sender, RoutedEventArgs e)
        //{
        //    SessionBase.Path = "/customer";
        //    Cccc_evtCallArrive();
        //}

        //private void Company_OnClick(object sender, RoutedEventArgs e)
        //{
        //    SessionBase.Path = "/company";
        //    Cccc_evtCallArrive();
        //}

        //private void User_OnClick(object sender, RoutedEventArgs e)
        //{
        //    SessionBase.Path = "/userlist";
        //    Cccc_evtCallArrive();
        //}






        private void ButtonCloseMenu_OnClick(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            BigLogo.Visibility = Visibility.Collapsed;
            SmallLogo.Visibility = Visibility.Visible;
        }

        private void ButtonOpenMenu_OnClick(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
            BigLogo.Visibility = Visibility.Visible;
            SmallLogo.Visibility = Visibility.Collapsed;
        }

        private void ClosedButton(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void MinimizedButton(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = View.SelectedIndex;
            switch (index)
            {
                case 0:
                    SessionBase.Path = "/CreateCase";
                    break;
                case 1:
                    SessionBase.Path = "/TaskList";
                    break;
                case 2:
                    SessionBase.Path = "/CaseList";
                    break;
                case 3:
                    SessionBase.Path = "/CustomerList";
                    break;
                case 4:
                    SessionBase.Path = "/CompanyList";
                    break;
                default:
                    SessionBase.Path = "/TaskList";
                    break;
            }
            CoreRouter();
        }

        private void CoreRouter()
        {
            if (!controls.ContainsKey(SessionBase.Path)) return;
            var content = controls[SessionBase.Path];
            switch (SessionBase.Path)
            {
                case "/CreateCase":
                    Display.Content = content;
                    break;
                case "/TaskList":
                    Display.Content = content;
                    break;
                case "/CaseList":
                    Display.Content = content;
                    break;
                case "/CustomerList":
                    Display.Content = content;
                    break;
                case "/CompanyList":
                    Display.Content = content;
                    break;
            }
        }




    }

}
