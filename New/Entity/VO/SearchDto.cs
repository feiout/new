using New.Common;

namespace New.Entity.VO
{
    public class SearchDto : NotificationObject
    {

        private string _saleId;
        public string saleId
        {
            get { return _saleId; }
            set
            {
                if (_saleId != value)
                {
                    _saleId = value;
                    RaisePropertyChanged("saleId");
                }
            }
        }

        private string _type;
        public string type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged("type");
                }
            }
        }

        private string _source;
        public string source
        {
            get { return _source; }
            set
            {
                if (_source != value)
                {
                    _source = value;
                    RaisePropertyChanged("source");
                }
            }
        }

        private string _status;
        public string status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged("status");
                }
            }
        }


        private string _saleProjectId;
        public string saleProjectId
        {
            get { return _saleProjectId; }
            set
            {
                if (_saleProjectId != value)
                {
                    _saleProjectId = value;
                    RaisePropertyChanged("saleProjectId");
                }
            }
        }

        private string _callType;
        public string callType
        {
            get { return _callType; }
            set
            {
                if (_callType != value)
                {
                    _callType = value;
                    RaisePropertyChanged("callType");
                }
            }
        }

        private string _subscriptionId;
        public string subscriptionId
        {
            get { return _subscriptionId; }
            set
            {
                if (_subscriptionId != value)
                {
                    _subscriptionId = value;
                    RaisePropertyChanged("subscriptionId");
                }
            }
        }

        private string _userId;
        public string userId
        {
            get { return _userId; }
            set
            {
                if (_userId != value)
                {
                    _userId = value;
                    RaisePropertyChanged("userId");
                }
            }
        }


        private string _createdStartDate;
        public string createdStartDate
        {
            get { return _createdStartDate; }
            set
            {
                if (_createdStartDate != value)
                {
                    _createdStartDate = value;
                    RaisePropertyChanged("createdStartDate");
                }
            }
        }

        private string _createdEndDate;
        public string createdEndDate
        {
            get { return _createdEndDate; }
            set
            {
                if (_createdEndDate != value)
                {
                    _createdEndDate = value;
                    RaisePropertyChanged("createdEndDate");
                }
            }
        }

        private string _pendingStartDate;
        public string pendingStartDate
        {
            get { return _pendingStartDate; }
            set
            {
                if (_pendingStartDate != value)
                {
                    _pendingStartDate = value;
                    RaisePropertyChanged("pendingStartDate");
                }
            }
        }

        private string _pendingEndDate;
        public string pendingEndDate
        {
            get { return _pendingEndDate; }
            set
            {
                if (_pendingEndDate != value)
                {
                    _pendingEndDate = value;
                    RaisePropertyChanged("pendingEndDate");
                }
            }
        }


        private GenericPagedList<ReturnVo> _pagedCaseList;
        public GenericPagedList<ReturnVo> PagedCaseList
        {
            get { return _pagedCaseList; }
            set
            {
                if (_pagedCaseList != value)
                {
                    _pagedCaseList = value;
                    RaisePropertyChanged("PagedCaseList");
                }
            }
        }

        private int _pageNumber;
        public int pageNumber
        {
            get { return _pageNumber; }
            set
            {
                if (_pageNumber != value)
                {
                    _pageNumber = value;
                    RaisePropertyChanged("pageNumber");
                }
            }
        }

        private int _pageSize;
        public int pageSize
        {
            get { return _pageSize; }
            set
            {
                if (_pageSize != value)
                {
                    _pageSize = value;
                    RaisePropertyChanged("pageSize");
                }
            }
        }

    }
}
