

using System;
using New.Common;

namespace New.Entity
{
    public class Product : NotificationObject
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

        private Decimal _price;
        public Decimal price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    RaisePropertyChanged("price");
                }
            }
        }


        private string _category;
        public string category
        {
            get { return _category; }
            set
            {
                if (_category != value)
                {
                    _category = value;
                    RaisePropertyChanged("category");
                }
            }
        }

        private string _description;
        public string description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged("description");
                }
            }
        }

    }
}
