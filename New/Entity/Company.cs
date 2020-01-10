

using System;
using System.Collections.ObjectModel;
using New.Common;

namespace New.Entity
{
    public class Company : NotificationObject
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

        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged("name");
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

        private string _website;
        public string website
        {
            get { return _website; }
            set
            {
                if (_website != value)
                {
                    _website = value;
                    RaisePropertyChanged("website");
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

        private string _note;
        public string note
        {
            get { return _note; }
            set
            {
                if (_note != value)
                {
                    _note = value;
                    RaisePropertyChanged("note");
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

        private ObservableCollection<Customer> _customerList;
        public ObservableCollection<Customer> customerList
        {
            get { return _customerList; }
            set
            {
                if (_customerList != value)
                {
                    _customerList = value;
                    RaisePropertyChanged("customerList");
                }
            }
        }

    }
}
