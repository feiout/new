using System;
using New.ViewModels;

namespace New.Views.Main
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Customer
    {
        private VmCustomer _vm;
        public Customer()
        {
            InitializeComponent();
        }


        private void Customer_OnInitialized(object sender, EventArgs e)
        {
            if (DataContext == null)
            {
                _vm = new VmCustomer();
                DataContext = _vm;
            }
            else
            {
                _vm = DataContext as VmCustomer;
            }
        }

    }
}
