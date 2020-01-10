using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using New.Entity;
using New.Entity.VO;
using New.RestUtility;

namespace New.Service
{
    public class MainService
    {
        public const string GetProvinceListUrl = "/common/provincelist";
        public const string GetIndustryListUrl = "/common/industrylist";
        public const string GetUserListUrl = "/common/userlist";
        public const string GetCompanyListUrl = "/common/companylist";
        public const string GetSaleProjectListUrl = "/common/saleprojectlist";
        public const string AuthenticationResourceUrl = "/user/authentication";
        public const string GetCityListUrl = "/common/citylist/";
        public const string GetInitCityListUrl = "/common/allcitylist";
        public const string SaveCaseUrl = "/Hwcase/add";
        public const string GetFilterCompanyByCompanyIdUrl = "/company/company/";
        public const string GetCityListByProvinceNameUrl = "/common/citylistbyprovincename/";
        public const string GetCompanyListByNameUrl = "/company/namelike/";
        public const string GetProductListUrl = "/common/productlist";
        public const string GetCasePagedByObjListUrl = "/Hwcase/filterPagedCaseByObj";

        

        public User Authentication(User user)
        {
            return RestHelper.Post(AuthenticationResourceUrl, user);
        }


        public ObservableCollection<Province> GetProvinceList(List<KeyValuePair<string, string>> conditions)
        {
            return RestHelper.Get<ObservableCollection<Province>>(GetProvinceListUrl, conditions);
        }

        internal ObservableCollection<City> GetInitCityList(List<KeyValuePair<string, string>> conditions)
        {
            return RestHelper.Get<ObservableCollection<City>>(GetInitCityListUrl, conditions);
        }

        public ObservableCollection<Industry> GetIndustryList(List<KeyValuePair<string, string>> conditions)
        {
            return RestHelper.Get<ObservableCollection<Industry>>(GetIndustryListUrl, conditions);
        }

        public ObservableCollection<User> GetUserList(List<KeyValuePair<string, string>> conditions)
        {
            return RestHelper.Get<ObservableCollection<User>>(GetUserListUrl, conditions);
        }

        public ObservableCollection<Company> GetCompanyList(List<KeyValuePair<string, string>> conditions)
        {
            return RestHelper.Get<ObservableCollection<Company>>(GetCompanyListUrl, conditions);
        }

        public ObservableCollection<SaleProject> GetSaleProjectList(List<KeyValuePair<string, string>> conditions)
        {
            return RestHelper.Get<ObservableCollection<SaleProject>>(GetSaleProjectListUrl, conditions);
        }

        public ObservableCollection<City> GetCityList(string provinceCode, List<KeyValuePair<string, string>> conditions)
        {
            return RestHelper.Get<ObservableCollection<City>>(GetCityListUrl + provinceCode, conditions);
        }

        public Hwcase SaveCase(Hwcase selectedCase)
        {
            return RestHelper.Post(SaveCaseUrl, selectedCase);
        }

        public Company GetFilterCompanyByCompanyId(string companyId, List<KeyValuePair<string, string>> conditions)
        {
            var url = GetFilterCompanyByCompanyIdUrl + companyId;
            return RestHelper.Get<Company>(url, conditions);
        }

        public ObservableCollection<City> GetCityListByProvinceName(string province, List<KeyValuePair<string, string>> conditions)
        {
            return RestHelper.Get<ObservableCollection<City>>(GetCityListByProvinceNameUrl + province, conditions);
        }

        public ObservableCollection<Company> GetCompanyListByName(string s, List<KeyValuePair<string, string>> conditions)
        {
            return RestHelper.Get<ObservableCollection<Company>>(GetCompanyListByNameUrl + s, conditions);
        }

        public ObservableCollection<City> GetCityListByProvinceNameAndCityName(string province, string city, List<KeyValuePair<string, string>> conditions)
        {
            return RestHelper.Get<ObservableCollection<City>>(GetCityListByProvinceNameUrl + province+"/"+ city, conditions);
        }

        public ObservableCollection<Product> GetProductList(List<KeyValuePair<string, string>> conditions)
        {
            return RestHelper.Get<ObservableCollection<Product>>(GetProductListUrl, conditions);
        }

        public SearchDto GetCasePagedByObjList(SearchDto searchDto)
        {
            return RestHelper.Post(GetCasePagedByObjListUrl, searchDto);
        }
    }
}
