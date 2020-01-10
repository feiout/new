using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using New.Entity;
using New.ViewModels;
using Torpedo.Windows;
using Torpedo.Windows.Controls;
using Torpedo.Windows.Controls.GridView;
using Torpedo.Windows.Controls.Primitives;
using GridViewColumn = Torpedo.Windows.Controls.GridViewColumn;

namespace New.Views.Case
{
    public partial class CreateCase
    {
        private VmCreateCase _vm;
        private bool SavePassport = true;
        public CreateCase()
        {
            InitializeComponent();
        }

        private void CreateCase_OnInitialized(object sender, EventArgs e)
        {
            if (DataContext == null)
            {
                _vm = new VmCreateCase();
                DataContext = _vm;
                _vm.SelectedCompany = new Company();
                _vm.SelectedIndustry = new Industry();
                _vm.SelectedProvince = new Province();
                _vm.SelectedCity = new City();
                _vm.SelectedParentCompany = new Company();
                _vm.SelectedUser = new User();
                _vm.SelectedSaleProject = new SaleProject();
                _vm.SelectedParentCompany = new Company();
                _vm.orderList=new ObservableCollection<Order>();
            }
            else
            {
                _vm = DataContext as VmCreateCase;
            }
            Products.AddHandler(RadAutoCompleteBox.KeyUpEvent,new KeyEventHandler(Cell_KeyUp));
            Products.AddHandler(RadAutoCompleteBox.SelectionChangedEvent, new SelectionChangedEventHandler(InputSelectionChanged));
        }

        private void InputSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RadGridView grid = sender as RadGridView;
            RadAutoCompleteBox inputSelector = e.OriginalSource as RadAutoCompleteBox;
            if (grid != null && inputSelector != null)
            {
                if (inputSelector.SelectedItem != null)
                {
                    var selectedItem = inputSelector.SelectedItem as Product;
                    if (selectedItem != null)
                    {
                        GridViewRowItem selectedRow = inputSelector.ParentOfType<GridViewRowItem>();
                        if (selectedRow == null) return;

                        var OR = selectedRow.Item as Order;
                        if (OR == null) return;
                        OR.productId = selectedItem.id;
                        OR.name = selectedItem.name;
                        OR.salesPrice = selectedItem.price;
                    }
                }
            }
        }

        private void ContextMenu_OnItemClick(object sender, RadRoutedEventArgs e)
        {
            var menuItem = e.OriginalSource as RadMenuItem;
            if (menuItem == null) return;
            var header = menuItem.Header as string;
            switch (header)
            {
                case "Delete":
                    DeletGridData();
                    break;
                case "Add":
                    AddGridData();
                    break;
            }

        }
        private void DeletGridData()
        {
            var OR = Products.SelectedItem as Order;
            _vm.orderList.Remove(OR);
        }
        private void AddGridData()
        {
            _vm.orderList.Add(new Order());
        }
        private void Cell_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                RadGridView gridView = sender as RadGridView;
                if (gridView == null) return;
                GridViewCell currentCell = gridView.CurrentCell;

                if (currentCell == null) return;
                GridViewRowItem rowItem = currentCell.ParentRow;
                if (rowItem == null) return;
                GridViewColumn currentColumn = currentCell.Column;
                if (currentColumn == null) return;
                bool isLastColumn = currentColumn.DisplayIndex == gridView.Columns.Count - 1;

                int columnIndex = currentColumn.DisplayIndex + 1;
                //非最后一列
                while (!isLastColumn)
                {
                    GridViewColumn nextColumn = gridView.Columns[columnIndex];
                    if ((nextColumn is GridViewDataColumn || nextColumn is GridViewComboBoxColumn) && nextColumn.IsVisible && !nextColumn.IsReadOnly)
                    {
                        GridViewCell nextCell = (GridViewCell)rowItem.Cells[columnIndex];
                        nextCell.BeginEdit();
                        break;
                    }
                    else
                    {
                        columnIndex++;
                        if (columnIndex >= gridView.Columns.Count - 1)
                        {
                            isLastColumn = true;
                        }
                    }
                }
                if (isLastColumn)
                {
                    if (gridView.Items.CurrentPosition == gridView.Items.Count - 1)
                    {
                        _vm.orderList.Add(new Order());
                    }
                    gridView.Items.MoveCurrentToNext();
                    gridView.UpdateLayout();
                    var rowList = gridView.ChildrenOfType<GridViewRow>().ToList();
                    if (rowList[0] is GridViewNewRow)
                    {
                        rowList.RemoveAt(0);
                    }
                    if (rowList.Count <= gridView.Items.CurrentPosition)
                    {
                        e.Handled = true;
                        return;
                    }
                    var newRowItem = rowList[gridView.Items.CurrentPosition];
                    columnIndex = 0;
                    isLastColumn = false;

                    //非最后一列
                    while (!isLastColumn)
                    {
                        GridViewColumn nextColumn = gridView.Columns[columnIndex];
                        if (nextColumn is GridViewDataColumn && nextColumn.IsVisible && !nextColumn.IsReadOnly)
                        {
                            GridViewCell nextCell = (GridViewCell)newRowItem.Cells[columnIndex];
                            nextCell.BeginEdit();
                            break;
                        }
                        else
                        {
                            columnIndex++;
                            if (columnIndex >= gridView.Columns.Count - 1)
                            {
                                isLastColumn = true;
                            }
                        }
                    }
                }
                e.Handled = true;
            }
        }

        private void ComboBoxCompany_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxCompany.SelectedItem != null)
            {
                _vm.SelectedCompany = (Company) ComboBoxCompany.SelectedItem;
                _vm.FilterCompany = _vm.FilterCompanyByCompanyId(_vm.SelectedCompany.companyId);
                ComboBoxCompany.SearchText = _vm.FilterCompany.name;
                ComboBoxProvince.SearchText = _vm.FilterCompany.province;
//                _vm.FilterCityByProvniceName(_vm.FilterCompany.province);
                StarLevel.SelectedValue = _vm.FilterCompany.priority;
                ParentsCompany.SearchText = _vm.FilterCompany.parentName;
                ComboBoxCity.SearchText= _vm.FilterCompany.city;
                Address.Text = _vm.FilterCompany.address;
                AccountNote.Text = _vm.FilterCompany.note;

                _vm.SelectedProvince.name = _vm.FilterCompany.province;
                _vm.SelectedIndustry = _vm.IndustryList.FirstOrDefault(d => d.name.Equals(_vm.FilterCompany.industry));
                if (_vm.SelectedCity != null) ComboBoxIndustry.SearchText = _vm.FilterCompany.industry;
                _vm.SelectedCity= _vm.CityList.FirstOrDefault(d => d.name.Equals(_vm.FilterCompany.city));
                _vm.SelectedParentCompany.companyId = _vm.FilterCompany.parentId;
                _vm.SelectedParentCompany.name = _vm.FilterCompany.parentName;
            }
        }



        private void BtnQuery_OnClick(object sender, RoutedEventArgs e)
        {
            Process proc = new System.Diagnostics.Process();
            string url = "https://www.baidu.com/baidu?&ie=utf-8&word=";
            string searchTxt = ComboBoxCompany.SearchText;
            string urlcode = System.Web.HttpUtility.UrlEncode(searchTxt);
            proc.StartInfo.FileName = url + urlcode;
            proc.Start();

        }


        private void ParentsCompany_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ParentsCompany.SelectedItem != null)
            {
                _vm.SelectedParentCompany = (Company)ParentsCompany.SelectedItem;
                ParentsCompany.SearchText = _vm.SelectedParentCompany.name;
            }

        }


        private void StarLevel_OnLoaded(object sender, RoutedEventArgs e)
        {
            CompanyPriorityLoading();

        }

        private void CompanyPriorityLoading()
        {
            StarLevel.SelectedIndex = 0;
        }

        private void BtnAdd_OnClick1(object sender, RoutedEventArgs e)
        {
            

        }

        private void ComboBoxGender_OnLoaded(object sender, RoutedEventArgs e)
        {
            GenderLoading();

        }

        private void GenderLoading()
        {
            ComboBoxGender.SelectedIndex = 0;
        }



        private void Create_OnClick(object sender, RoutedEventArgs e)
        {
            VolidationChe();
            if (!SavePassport)
            {
                return;;
            }

            //processing data
            //company信息
            if (_vm.SelectedCompany.companyId != null)
            {
                _vm.SelectedCase.companyId = _vm.SelectedCompany.companyId;
            }
            _vm.SelectedCase.companyName = ComboBoxCompany.SearchText.Trim();
            if (_vm.SelectedIndustry.name != null)
            {
                _vm.SelectedCase.industry = _vm.SelectedIndustry.name;
            }
            if (_vm.SelectedProvince.name!=null)
            {
                _vm.SelectedCase.province = _vm.SelectedProvince.name;
            }
            if (_vm.SelectedCity.name != null)
            {
                _vm.SelectedCase.city = _vm.SelectedCity.name;
            }
            if (ParentsCompany.SearchText.Trim().Equals(""))
            {
                _vm.SelectedParentCompany = null;
                _vm.SelectedCase.parentId = null;
                _vm.SelectedCase.parentName = null;
            }
            else
            {
                _vm.SelectedCase.parentId = _vm.SelectedParentCompany.companyId;
                _vm.SelectedCase.parentName = _vm.SelectedParentCompany.name;
            }
            //contact 信息直传了
            //case信息
            if (_vm.SelectedUser.userId != null)
            {
                _vm.SelectedCase.userId = _vm.SelectedUser.userId;
                _vm.SelectedCase.subscriptionId = _vm.SelectedUser.subscriptionId;
            }
            if (_vm.SelectedSaleProject.saleProjectId != null)
            {
                _vm.SelectedCase.saleProjectId = _vm.SelectedSaleProject.saleProjectId;
                _vm.SelectedCase.saleProjectName = _vm.SelectedSaleProject.name;
            }

            //validation data
            if (_vm.SelectedParentCompany != null && _vm.SelectedParentCompany.companyId != null)
            {
                if (_vm.SelectedCase.companyId == _vm.SelectedParentCompany.companyId)
                {
                    MessageBox.Show("selected company can not be parents!");
                    ParentsCompany.SelectedItem = null;
                    ParentsCompany.SearchText = string.Empty;
                    _vm.SelectedParentCompany = new Company();
                    ParentsCompany.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 0, 0));
                }
            }
            else
            {
                ParentsCompany.SearchText = string.Empty;
                ParentsCompany.SelectedItem = null;
                _vm.SelectedParentCompany = new Company();
            }

            //保存case
            _vm.SelectedCase.createDate = DateTime.Now;
            _vm.SelectedCase.pendingDate = DateTime.Now.AddDays(14);
            _vm.SelectedCase.status = "0"; //默认status是Initial
            _vm.SelectedCase.callType = "OB"; //手动创建默认type是Outbound call,  弹窗创建默认是Inbound call
            _vm.CreatenewCase(_vm.SelectedCase);

            //清空数据
            _vm.SelectedCase = new Hwcase();
            ComboBoxCompany.SearchText = "";
            ComboBoxIndustry.SearchText = "";
            ComboBoxProvince.SearchText = "";
            ComboBoxCity.SearchText = "";
            CompanyPriorityLoading();
            ParentsCompany.SearchText = "";
            GenderLoading();
            TypeLoading();
            SourcodeLoading();
            ComboInsalesSales.SearchText = "";
            Campaigns.SearchText = "";
            _vm.SelectedCompany=new Company();
            _vm.SelectedIndustry=new Industry();
            _vm.SelectedProvince=new Province();
            _vm.SelectedCity=new City();
            _vm.SelectedParentCompany=new Company();
            _vm.SelectedUser=new User();
            _vm.SelectedSaleProject=new SaleProject();
            _vm.SelectedParentCompany=new Company();

            //            _vm.QueryDicData();

        }

        private void VolidationChe()
        {
            //必填项遗漏变红色
            if (string.IsNullOrEmpty(ComboBoxCompany.SearchText.Trim()))
            {
                A1.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 0, 0));
                SavePassport = false;
            }
            else
            {
                A1.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
                SavePassport = true;
            }
            if (LastName.Text == "")
            {
                A3.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 0, 0));
                SavePassport = false;
            }
            else
            {
                A3.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
                SavePassport = true;
            }
            if (string.IsNullOrEmpty(ComboInsalesSales.SearchText.Trim()))
            {
                A2.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 0, 0));
                SavePassport = false;
            }
            else
            {
                A3.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
                SavePassport = true;
            }
            if (Mails.Text == "")
            {
                Mails.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 0, 0));
                SavePassport = false;
            }
            else
            {
                Mails.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
                SavePassport = true;
            }


            if (!_vm.IndustryList.ToList().Exists(p => p.name == ComboBoxIndustry.SearchText.Trim()))
            {
                A5.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 0, 0));
                SavePassport = false;
            }
            else
            {
                A5.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
                SavePassport = true;
            }
            if (!string.IsNullOrEmpty(ParentsCompany.SearchText.Trim()))
            {
                if (!_vm.ParentCompanyList.ToList().Exists(p => p.name == ParentsCompany.SearchText.Trim()))
                {
                    ParentTitle.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 0, 0));
                    SavePassport = false;
                }
                else
                {
                    ParentTitle.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
                    SavePassport = true;
                }
            }
            else
            {
                ParentTitle.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
                SavePassport = true;
            }
            if (!_vm.ProvinceList.ToList().Exists(p => p.name == ComboBoxProvince.SearchText.Trim()))
            {
                A7.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 0, 0));
                SavePassport = false;
            }
            else
            {
                A7.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
                SavePassport = true;
            }

        }


        private void ComboBoxIndustry_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxIndustry.SelectedItem != null)
            {
                _vm.SelectedIndustry = (Industry) ComboBoxIndustry.SelectedItem;
                ComboBoxIndustry.SearchText = _vm.SelectedIndustry.name;
            }

        }

        private void ComboBoxProvince_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxProvince.SelectedItem != null)
            {
                _vm.SelectedProvince = (Province)ComboBoxProvince.SelectedItem;
                ComboBoxProvince.SearchText = _vm.SelectedProvince.name;
//                _vm.FilterCity(_vm.SelectedProvince.code);
//                ComboBoxCity.ItemsSource = _vm.CityList;
//                ComboBoxCity.SelectedIndex = 0;
                ComboBoxCity.IsEnabled = true;
                ComboBoxCity.Focus();
            }
            else
            {
                ComboBoxCity.IsEnabled = false;
            }
        }


        private void Campaigns_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (Campaigns.SelectedItem != null)
            {
                _vm.SelectedSaleProject = (SaleProject) Campaigns.SelectedItem;
                Campaigns.SearchText = _vm.SelectedSaleProject.name;
            }
        }

        private void ComboInsalesSales_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboInsalesSales.SelectedItem != null)
            {
                _vm.SelectedUser = (User) ComboInsalesSales.SelectedItem;
                ComboInsalesSales.SearchText = _vm.SelectedUser.name;
            }

        }

        private void Types_OnLoaded(object sender, RoutedEventArgs e)
        {
            TypeLoading();
        }

        private void TypeLoading()
        {
            Types.SelectedIndex = 0;
        }

        private void SourceCode_OnLoaded(object sender, RoutedEventArgs e)
        {
            SourcodeLoading();
        }

        private void SourcodeLoading()
        {

            SourceCode.SelectedIndex = 0;
        }

        private void ComboBoxCompany_OnSearchTextChanged(object sender, EventArgs e)
        {
            if (ComboBoxCompany.SearchText.Contains("/"))
            {
                MessageBox.Show("Cannot contain '/'");
                return;
            }
            if (ComboBoxCompany.SearchText.Contains("?"))
            {
                MessageBox.Show("Cannot contain '?'");
                return;
            }
            if (ComboBoxCompany.SearchText.Contains("#"))
            {
                MessageBox.Show("Cannot contain '#'");
                return;
            }
            if (ComboBoxCompany.SearchText.Trim() != "")
            {
                _vm.CompanyList= _vm.FilterCompanyList(ComboBoxCompany.SearchText.Trim());
                ComboBoxCompany.ItemsSource = _vm.CompanyList;
            }

        }

//        private IEnumerable FilterCompanyList(ObservableCollection<Company> companyList, string s)
//        {
//            _vm.TCompanyList = new ObservableCollection<Company>();
//            for (int i = 0; i < companyList.Count; i++)
//            {
//                if (companyList[i].name.Contains(s))
//                {
//                    _vm.CompanyList.Add(companyList[i]);
//                }
//            }
//            return _vm.TCompanyList;
//        }
        private void ParentsCompany_OnSearchTextChanged(object sender, EventArgs e)
        {
            if (ParentsCompany.SearchText.Contains("/"))
            {
                MessageBox.Show("Cannot contain '/'");
                return;
            }
            if (ParentsCompany.SearchText.Contains("?"))
            {
                MessageBox.Show("Cannot contain '?'");
                return;
            }
            if (ParentsCompany.SearchText.Contains("#"))
            {
                MessageBox.Show("Cannot contain '#'");
                return;
            }
            if (ParentsCompany.SearchText.Trim() != "")
            {
                _vm.ParentCompanyList = _vm.FilterCompanyList(ParentsCompany.SearchText.Trim());
                ParentsCompany.ItemsSource = _vm.ParentCompanyList;
            }
        }

        private void UpdateCompany_OnClick(object sender, RoutedEventArgs e)
        {
            

        }

        private void UpdateContact_OnClick(object sender, RoutedEventArgs e)
        {
            

        }

        private void ComboBoxCity_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxCity.SelectedItem != null)
            {
                _vm.SelectedCity = (City) ComboBoxCity.SelectedItem;
                ComboBoxCity.SearchText = _vm.SelectedCity.name;
            }

        }

        private void ComboBoxCity_OnSearchTextChanged(object sender, EventArgs e)
        {
            if (ComboBoxCity.SearchText.Trim() != "")
            {
                if (!ComboBoxProvince.SearchText.Trim().Equals(null))
                {
                    _vm.CityList = _vm.FilterCityList(ComboBoxCity.SearchText.Trim(), ComboBoxProvince.SearchText.Trim());
                    ComboBoxCity.ItemsSource = _vm.CityList;
                }
            }

        }

        private void Category_OnLoaded(object sender, RoutedEventArgs e)
        {
            Category.SelectedIndex = 0;
        }


    }
}
