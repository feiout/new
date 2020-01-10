using System;
using System.Windows;
using New.Base;
using New.Entity.VO;
using New.ViewModels;
using Torpedo.Windows.Controls;

namespace New.Views.Main
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class CaseList
    {
        private VmCase _vm;
        public CaseList()
        {
            InitializeComponent();
        }


        private void CaseList_OnInitialized(object sender, EventArgs e)
        {
            if (DataContext == null)
            {
                _vm = new VmCase();
                DataContext = _vm;
            }
            else
            {
                _vm = DataContext as VmCase;
            }
            Refresh();
        }

        private void Refresh()
        {
            _vm.SearchDto=new SearchDto();
            _vm.SearchDto.callType = "-1";
            _vm.SearchDto.createdStartDate = "-1";
            _vm.SearchDto.createdEndDate = "-1";
            _vm.SearchDto.pendingStartDate = "2016-01-01";
            _vm.SearchDto.pendingEndDate= DateTime.Now.AddDays(6).ToString("yyyy-MM-dd");
            _vm.SearchDto.pageNumber = 0;
            _vm.SearchDto.pageSize = 2;
            _vm.SearchDto.saleId = "-1";
            _vm.SearchDto.saleProjectId = "-1";
            _vm.SearchDto.source = "-1";
            _vm.SearchDto.status = "-1";
            _vm.SearchDto.subscriptionId = SessionBase.User.subscriptionId;
            _vm.SearchDto.type = "-1";
            Cstart.SelectedValue = System.DateTime.Parse("2016/12/1");
            Cend.SelectedDate = DateTime.Now.AddDays(6);
            _vm.GetPagedCaseList(_vm.SearchDto);
        }

        private void DateType_OnLoaded(object sender, RoutedEventArgs e)
        {
            DateType.SelectedIndex = 0;
        }

        private void CaseStatus_OnLoaded(object sender, RoutedEventArgs e)
        {
            CaseStatus.SelectedIndex = 0;
        }

        private void CaseType_OnLoaded(object sender, RoutedEventArgs e)
        {
            CaseType.SelectedIndex = 0;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void FileDataPager_PageIndexChanged(object sender, PageIndexChangedEventArgs e)
        {
            if (e.OldPageIndex != -1)
            {
                _vm.SearchDto.pageNumber = e.NewPageIndex;
                _vm.GetPagedCaseList(_vm.SearchDto);
             

            }

        }
    }
}
