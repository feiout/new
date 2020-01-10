

using New.Common;

namespace New.Entity
{
    public class City : NotificationObject
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

        private string _code;
        public string code
        {
            get { return _code; }
            set
            {
                if (_code != value)
                {
                    _code = value;
                    RaisePropertyChanged("code");
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



        private string _provinceCode;
        public string provinceCode
        {
            get { return _provinceCode; }
            set
            {
                if (_provinceCode != value)
                {
                    _provinceCode = value;
                    RaisePropertyChanged("provinceCode");
                }
            }
        }


    }
}
