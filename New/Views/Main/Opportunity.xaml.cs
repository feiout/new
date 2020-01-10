using System;
using System.Windows;
using New.ViewModels;

namespace New.Views.Main
{
    public partial class Opportunity 
    {
        private VmOpportunity _vm;
        public Opportunity()
        {
            InitializeComponent();
        }

        private void DateType_OnLoaded(object sender, RoutedEventArgs e)
        {
            DateType.SelectedIndex = 0;

        }

        private void Opportunity_OnInitialized_OnInitialized(object sender, EventArgs e)
        {
            if (DataContext == null)
            {
                _vm = new VmOpportunity();
                DataContext = _vm;
            }
            else
            {
                _vm = DataContext as VmOpportunity;
            }
        }
    }
}
