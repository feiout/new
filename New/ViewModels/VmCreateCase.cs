using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Navigation;
using New.Base;
using New.Entity;
using New.Entity.VO;
using New.RestUtility;
using New.Service;
using Torpedo.Windows.Controls;
using ViewModelBase = New.Base.ViewModelBase;


namespace New.ViewModels
{
    public class VmCreateCase : ViewModelBase
    {
        private readonly MainService _mainService = ServiceHelper<MainService>.CreateInterface();
        public List<KeyValuePair<string, string>> Conditions = new List<KeyValuePair<string, string>>();

        public VmCreateCase()
        {
            InitialStaticResource();
        }

        private void InitialStaticResource()
        {
            SelectedCase=new Hwcase();
            QueryDicData();
        }

        
        private Industry _selectedIndustry;
        public Industry SelectedIndustry
        {
            get { return _selectedIndustry; }
            set
            {
                if (_selectedIndustry != value)
                {
                    _selectedIndustry = value;
                    RaisePropertyChanged("SelectedIndustry");
                }
            }
        }

        private Province _selectedProvince;
        public Province SelectedProvince
        {
            get { return _selectedProvince; }
            set
            {
                if (_selectedProvince != value)
                {
                    _selectedProvince = value;
                    RaisePropertyChanged("SelectedProvince");
                }
            }
        }

        private Hwcase _selectedCase;
        public Hwcase SelectedCase
        {
            get { return _selectedCase; }
            set
            {
                if (_selectedCase != value)
                {
                    _selectedCase = value;
                    RaisePropertyChanged("SelectedCase");
                }
            }
        }

        private Company _selectedCompany;
        public Company SelectedCompany
        {
            get { return _selectedCompany; }
            set
            {
                if (_selectedCompany != value)
                {
                    _selectedCompany = value;
                    RaisePropertyChanged("SelectedCompany");
                }
            }
        }

        private Company _filterCompany;
        public Company FilterCompany
        {
            get { return _filterCompany; }
            set
            {
                if (_filterCompany != value)
                {
                    _filterCompany = value;
                    RaisePropertyChanged("FilterCompany");
                }
            }
        }


        private Company _selectedParentCompany;
        public Company SelectedParentCompany
        {
            get { return _selectedParentCompany; }
            set
            {
                if (_selectedParentCompany != value)
                {
                    _selectedParentCompany = value;
                    RaisePropertyChanged("SelectedParentCompany");
                }
            }
        }


        private City _selectedCity;
        public City SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                if (_selectedCity != value)
                {
                    _selectedCity = value;
                    RaisePropertyChanged("SelectedCity");
                }
            }
        }

        private User _selectedUser;
        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                if (_selectedUser != value)
                {
                    _selectedUser = value;
                    RaisePropertyChanged("SelectedUser");
                }
            }
        }

        private SaleProject _selectedSaleProject;
        public SaleProject SelectedSaleProject
        {
            get { return _selectedSaleProject; }
            set
            {
                if (_selectedSaleProject != value)
                {
                    _selectedSaleProject = value;
                    RaisePropertyChanged("SelectedSaleProject");
                }
            }
        }



        private ObservableCollection<SaleProject> _saleProjectList;
        public ObservableCollection<SaleProject> SaleProjectList
        {
            get { return _saleProjectList; }
            set
            {
                if (_saleProjectList != value)
                {
                    _saleProjectList = value;
                    RaisePropertyChanged("SaleProjectList");
                }
            }
        }


        private ObservableCollection<Company> _companyList;
        public ObservableCollection<Company> CompanyList
        {
            get { return _companyList; }
            set
            {
                if (_companyList != value)
                {
                    _companyList = value;
                    RaisePropertyChanged("CompanyList");
                }
            }
        }

        private ObservableCollection<Company> _parentCompanyList;
        public ObservableCollection<Company> ParentCompanyList
        {
            get { return _parentCompanyList; }
            set
            {
                if (_parentCompanyList != value)
                {
                    _parentCompanyList = value;
                    RaisePropertyChanged("ParentCompanyList");
                }
            }
        }


        private ObservableCollection<Company> _TcompanyList;
        public ObservableCollection<Company> TCompanyList
        {
            get { return _TcompanyList; }
            set
            {
                if (_TcompanyList != value)
                {
                    _TcompanyList = value;
                    RaisePropertyChanged("TCompanyList");
                }
            }
        }

        private ObservableCollection<Province> _provinceList;
        public ObservableCollection<Province> ProvinceList
        {
            get { return _provinceList; }
            set
            {
                if (_provinceList != value)
                {
                    _provinceList = value;
                    RaisePropertyChanged("ProvinceList");
                }
            }
        }

        private ObservableCollection<City> _cityList;
        public ObservableCollection<City> CityList
        {
            get { return _cityList; }
            set
            {
                if (_cityList != value)
                {
                    _cityList = value;
                    RaisePropertyChanged("CityList");
                }
            }
        }

        private ObservableCollection<City> _allCityList;
        public ObservableCollection<City> AllCityList
        {
            get { return _allCityList; }
            set
            {
                if (_allCityList != value)
                {
                    _allCityList = value;
                    RaisePropertyChanged("AllCityList");
                }
            }
        }

        private ObservableCollection<City> _TempCityList;
        public ObservableCollection<City> TempCityList
        {
            get { return _TempCityList; }
            set
            {
                if (_TempCityList != value)
                {
                    _TempCityList = value;
                    RaisePropertyChanged("TempCityList");
                }
            }
        }

        private ObservableCollection<Order> _orderList;
        public ObservableCollection<Order> orderList
        {
            get { return _orderList; }
            set
            {
                if (_orderList != value)
                {
                    _orderList = value;
                    RaisePropertyChanged("orderList");
                }
            }
        }


        private ObservableCollection<Industry> _industryList;
        public ObservableCollection<Industry> IndustryList
        {
            get { return _industryList; }
            set
            {
                if (_industryList != value)
                {
                    _industryList = value;
                    RaisePropertyChanged("IndustryList");
                }
            }
        }

        private ObservableCollection<Product> _productList;
        public ObservableCollection<Product> ProductList
        {
            get { return _productList; }
            set
            {
                if (_productList != value)
                {
                    _productList = value;
                    RaisePropertyChanged("ProductList");
                }
            }
        }


        private ObservableCollection<User> _userList;
        public ObservableCollection<User> UserList
        {
            get { return _userList; }
            set
            {
                if (_userList != value)
                {
                    _userList = value;
                    RaisePropertyChanged("UserList");
                }
            }
        }


        public void CreatenewCase(Hwcase selectedCase)
        {
            var result = _mainService.SaveCase(selectedCase);
            if (result.id != -1)
            {
                MessageBox.Show("Case Saved!");
            }
            else
            {
                if (result.ex != null)
                {
                    MessageBox.Show(result.ex);
                }
                else
                {
                    MessageBox.Show("Saved Failed!");
                }
            }
        }

        public Company FilterCompanyByCompanyId(string companyId)
        {
            FilterCompany = _mainService.GetFilterCompanyByCompanyId(companyId,Conditions);
            return FilterCompany;
        }


        public void FilterCity(string provinceCode)
        {
            CityList = _mainService.GetCityList(provinceCode, Conditions);

        }

        public void FilterCityByProvniceName(string province)
        {
            CityList = _mainService.GetCityListByProvinceName(province,Conditions);
        }

        public void QueryDicData()
        {
            UserList = _mainService.GetUserList(Conditions);
            SaleProjectList = _mainService.GetSaleProjectList(Conditions);
            ProvinceList = _mainService.GetProvinceList(Conditions);
            IndustryList = _mainService.GetIndustryList(Conditions);
            ProductList = _mainService.GetProductList(Conditions);
        }


        public ObservableCollection<Company> FilterCompanyList(string s)
        {
            TCompanyList = _mainService.GetCompanyListByName(s, Conditions);
            return TCompanyList;
        }

        public ObservableCollection<City> FilterCityList(string city, string province)
        {
            TempCityList= _mainService.GetCityListByProvinceNameAndCityName(province, city, Conditions);
            return TempCityList;
        }
    }
}
