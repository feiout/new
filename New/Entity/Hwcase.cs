

using System;
using New.Common;

namespace New.Entity
{
    public class Hwcase : NotificationObject
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged("id");
                }
            }
        }

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

        private DateTime _pendingDate;
        public DateTime pendingDate
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

        private string _saleProjectName;
        public string saleProjectName
        {
            get { return _saleProjectName; }
            set
            {
                if (_saleProjectName != value)
                {
                    _saleProjectName = value;
                    RaisePropertyChanged("saleProjectName");
                }
            }
        }

        private DateTime _createDate;
        public DateTime createDate
        {
            get { return _createDate; }
            set
            {
                if (_createDate != value)
                {
                    _createDate = value;
                    RaisePropertyChanged("createDate");
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

        private string _province;
        public string province
        {
            get { return _province; }
            set
            {
                if (_province != value)
                {
                    _province = value;
                    RaisePropertyChanged("province");
                }
            }
        }

        private string _city;
        public string city
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    RaisePropertyChanged("city");
                }
            }
        }

        private string _address;
        public string address
        {
            get { return _address; }
            set
            {
                if (_address != value)
                {
                    _address = value;
                    RaisePropertyChanged("address");
                }
            }
        }

        private string _industry;
        public string industry
        {
            get { return _industry; }
            set
            {
                if (_industry != value)
                {
                    _industry = value;
                    RaisePropertyChanged("industry");
                }
            }
        }

        private string _priority;
        public string priority
        {
            get { return _priority; }
            set
            {
                if (_priority != value)
                {
                    _priority = value;
                    RaisePropertyChanged("priority");
                }
            }
        }

        private string _parentId;
        public string parentId
        {
            get { return _parentId; }
            set
            {
                if (_parentId != value)
                {
                    _parentId = value;
                    RaisePropertyChanged("parentId");
                }
            }
        }

        private string _parentName;
        public string parentName
        {
            get { return _parentName; }
            set
            {
                if (_parentName != value)
                {
                    _parentName = value;
                    RaisePropertyChanged("parentName");
                }
            }
        }

        private string _title;
        public string title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    RaisePropertyChanged("title");
                }
            }
        }

        private string _email;
        public string email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    RaisePropertyChanged("email");
                }
            }
        }

        private string _department;
        public string department
        {
            get { return _department; }
            set
            {
                if (_department != value)
                {
                    _department = value;
                    RaisePropertyChanged("department");
                }
            }
        }


        private string _gender;
        public string gender
        {
            get { return _gender; }
            set
            {
                if (_gender != value)
                {
                    _gender = value;
                    RaisePropertyChanged("gender");
                }
            }
        }

        private string _caseNote;
        public string caseNote
        {
            get { return _caseNote; }
            set
            {
                if (_caseNote != value)
                {
                    _caseNote = value;
                    RaisePropertyChanged("caseNote");
                }
            }
        }

        private string _companyNote;
        public string companyNote
        {
            get { return _companyNote; }
            set
            {
                if (_companyNote != value)
                {
                    _companyNote = value;
                    RaisePropertyChanged("companyNote");
                }
            }
        }

        private string _customerNote;
        public string customerNote
        {
            get { return _customerNote; }
            set
            {
                if (_customerNote != value)
                {
                    _customerNote = value;
                    RaisePropertyChanged("customerNote");
                }
            }
        }

        private string _ex;
        public string ex
        {
            get { return _ex; }
            set
            {
                if (_ex != value)
                {
                    _ex = value;
                    RaisePropertyChanged("ex");
                }
            }
        }


    }
}
