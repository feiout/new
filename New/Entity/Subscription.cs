

using System;
using New.Common;

namespace New.Entity
{
    public class Subscription : NotificationObject
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

        private int _amount;
        public int amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    RaisePropertyChanged("amount");
                }
            }
        }

        private DateTime _expireDate;
        public DateTime expireDate
        {
            get { return _expireDate; }
            set
            {
                if (_expireDate != value)
                {
                    _expireDate = value;
                    RaisePropertyChanged("expireDate");
                }
            }
        }

    }
}
