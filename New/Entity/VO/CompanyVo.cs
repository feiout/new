using New.Common;

namespace New.Entity.VO
{
    public class CompanyVo : NotificationObject
    {
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

       

    }
}
