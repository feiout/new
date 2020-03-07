using System;
using New.ViewModels;

namespace New.Views.Main
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class CompanyList
    {
        private VmCompany _vm;
        public CompanyList()
        {
            InitializeComponent();
        }


        private void Company_OnInitialized(object sender, EventArgs e)
        {
            if (DataContext == null)
            {
                _vm = new VmCompany();
                DataContext = _vm;
            }
            else
            {
                _vm = DataContext as VmCompany;
            }
        }

    }
}
