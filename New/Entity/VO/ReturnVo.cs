using System;
using New.Common;

namespace New.Entity.VO
{
    public class ReturnVo : NotificationObject
    {

        private string _caseId;
        public string caseId
        {
            get { return _caseId; }
            set
            {
                if (_caseId != value)
                {
                    _caseId = value;
                    RaisePropertyChanged("caseId");
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


        private string _companyId;
        public string companyId
        {
            get { return _companyId; }
            set
            {
                if (_companyId != value)
                {
                    _companyId = value;
                    RaisePropertyChanged("companyId");
                }
            }
        }

        private string _companyName;
        public string companyName
        {
            get { return _companyName; }
            set
            {
                if (_companyName != value)
                {
                    _companyName = value;
                    RaisePropertyChanged("companyName");
                }
            }
        }

        private string _customerId;
        public string customerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    RaisePropertyChanged("customerId");
                }
            }
        }

        private string _customerName;
        public string customerName
        {
            get { return _customerName; }
            set
            {
                if (_customerName != value)
                {
                    _customerName = value;
                    RaisePropertyChanged("customerName");
                }
            }
        }

        private string _cellphone;
        public string cellphone
        {
            get { return _cellphone; }
            set
            {
                if (_cellphone != value)
                {
                    _cellphone = value;
                    RaisePropertyChanged("cellphone");
                }
            }
        }

        private string _workphone;
        public string workphone
        {
            get { return _workphone; }
            set
            {
                if (_workphone != value)
                {
                    _workphone = value;
                    RaisePropertyChanged("workphone");
                }
            }
        }

        private string _pendingDate;
        public string pendingDate
        {
            get { return _pendingDate; }
            set
            {
                if (_pendingDate != value)
                {
                    _pendingDate = value;
                    RaisePropertyChanged("pendingDate");
                }
            }
        }


    }
}
