

using New.Common;

namespace New.Entity
{
    public class SaleProject : NotificationObject
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

        private string _responsible;
        public string responsible
        {
            get { return _responsible; }
            set
            {
                if (_responsible != value)
                {
                    _responsible = value;
                    RaisePropertyChanged("responsible");
                }
            }
        }


    }
}
