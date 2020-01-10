

using System;
using New.Common;

namespace New.Entity
{
    public class Customer : NotificationObject
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

        private int _gender;
        public int gender
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

        private DateTime _nextVisit;
        public DateTime nextVisit
        {
            get { return _nextVisit; }
            set
            {
                if (_nextVisit != value)
                {
                    _nextVisit = value;
                    RaisePropertyChanged("nextVisit");
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

    }
}
