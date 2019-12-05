

using System;
using New.Common;

namespace New.Entity
{
    public class Userlogs : NotificationObject
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

        private int _userId;
        public int userId
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

        private DateTime _lastLognDate;
        public DateTime lastLognDate
        {
            get { return _lastLognDate; }
            set
            {
                if (_lastLognDate != value)
                {
                    _lastLognDate = value;
                    RaisePropertyChanged("lastLognDate");
                }
            }
        }

        private DateTime _lastChange;
        public DateTime lastChange
        {
            get { return _lastChange; }
            set
            {
                if (_lastChange != value)
                {
                    _lastChange = value;
                    RaisePropertyChanged("lastChange");
                }
            }
        }



    }
}
