using New.Common;

namespace New.Entity.VO
{
    public class ResultVo : NotificationObject
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
