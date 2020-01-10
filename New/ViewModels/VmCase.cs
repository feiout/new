using System.Collections.Generic;
using System.Collections.ObjectModel;
using New.Base;
using New.Entity;
using New.Entity.VO;
using New.RestUtility;
using New.Service;


namespace New.ViewModels
{
    public class VmCase : ViewModelBase
    {
        private readonly MainService _mainService = ServiceHelper<MainService>.CreateInterface();
        public List<KeyValuePair<string, string>> Conditions = new List<KeyValuePair<string, string>>();

        public VmCase()
        {
            InitialStaticResource();
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

        private SearchDto _searchDto;

        public SearchDto SearchDto
        {
            get { return _searchDto; }
            set
            {
                if (_searchDto != value)
                {
                    _searchDto = value;
                    RaisePropertyChanged("SearchDto");
                }
            }
        }

        private GenericPagedList<ReturnVo> _casePageList;
        public GenericPagedList<ReturnVo> CasePageList
        {
            get { return _casePageList; }
            set
            {
                if (_casePageList != value)
                {
                    _casePageList = value;
                    RaisePropertyChanged("CasePageList");
                }
            }
        }

        private ObservableCollection<ReturnVo> _cases;
        public ObservableCollection<ReturnVo> cases
        {
            get { return _cases; }
            set
            {
                if (_cases != value)
                {
                    _cases = value;
                    RaisePropertyChanged("cases");
                }
            }
        }

        private long _totalElements;

        public long totalElements
        {
            get { return _totalElements; }
            set
            {
                if (_totalElements != value)
                {
                    _totalElements = value;
                    RaisePropertyChanged("totalElements");
                }
            }
        }

        private int _totalPages;

        public int totalPages
        {
            get { return _totalPages; }
            set
            {
                if (_totalPages != value)
                {
                    _totalPages = value;
                    RaisePropertyChanged("totalPages");
                }
            }
        }


        private void InitialStaticResource()
        {
            SaleProjectList = _mainService.GetSaleProjectList(Conditions);

        }

        public void GetPagedCaseList(SearchDto searchDto)
        {
            var result = _mainService.GetCasePagedByObjList(searchDto);
            CasePageList = result.PagedCaseList;
            cases = CasePageList.PagedList;
            totalElements = CasePageList.totalElements;
            totalPages = CasePageList.totalPages;

        }
    }
}
