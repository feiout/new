using New.Common;

namespace New.Base
{
    public class ViewModelBase : NotificationObject
    {
        public  Dictionary Dictionary { get; private set; }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                if (_isBusy != value)
                {
                    _isBusy = value;
                    RaisePropertyChanged("IsBusy");
                }
            }
        }

        public ViewModelBase()
        {
           Dictionary =Dictionary.Instance;
        }

    }
}
