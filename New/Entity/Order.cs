

using System;
using New.Common;

namespace New.Entity
{
    public class Order : NotificationObject
    {
        private int _productId;
        public int productId
        {
            get { return _productId; }
            set
            {
                if (_productId != value)
                {
                    _productId = value;
                    RaisePropertyChanged("productId");
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

        private int _orderAmount;
        public int orderAmount
        {
            get { return _orderAmount; }
            set
            {
                if (_orderAmount != value)
                {
                    _orderAmount = value;
                    RaisePropertyChanged("orderAmount");
                }
            }
        }

        private Decimal _salesPrice;
        public Decimal salesPrice
        {
            get { return _salesPrice; }
            set
            {
                if (_salesPrice != value)
                {
                    _salesPrice = value;
                    RaisePropertyChanged("salesPrice");
                }
            }
        }


        private DateTime _orderDate = DateTime.Now;

        public DateTime orderDate
        {
            get { return _orderDate; }
            set
            {
                if (_orderDate != value)
                {
                    _orderDate = value;
                    RaisePropertyChanged("orderDate");
                }
            }
        }

    }
}
