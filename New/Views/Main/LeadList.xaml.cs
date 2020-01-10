using System;
using System.Windows;
using New.ViewModels;

namespace New.Views.Main
{

    public partial class LeadList
    {
        private VmLead _vm;
        public LeadList()
        {
            InitializeComponent();
        }

        private void DateType_OnLoaded(object sender, RoutedEventArgs e)
        {
            DateType.SelectedIndex = 0;
        }

        private void LeadList_OnInitialized(object sender, EventArgs e)
        {
            if (DataContext == null)
            {
                _vm = new VmLead();
                DataContext = _vm;
            }
            else
            {
                _vm = DataContext as VmLead;
            }
        }
    }
}
