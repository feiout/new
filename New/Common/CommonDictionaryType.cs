namespace New.Common
{
    public class CommonDictionaryType : NotificationObject
    {
        /// <summary>
        /// ID
        /// </summary>
        private string _id;
        public string id
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

        /// <summary>
        /// 类型代码
        /// </summary>
        private string _typeCode;
        public string typeCode
        {
            get { return _typeCode; }
            set
            {
                if (_typeCode != value)
                {
                    _typeCode = value;
                    RaisePropertyChanged("typeCode");
                }
            }
        }

        /// <summary>
        /// 类型名称
        /// </summary>
        private string _typeName;
        public string typeName
        {
            get { return _typeName; }
            set
            {
                if (_typeName != value)
                {
                    _typeName = value;
                    RaisePropertyChanged("typeName");
                }
            }
        }

        /// <summary>
        /// ID
        /// </summary>
        public const string ID = "id";
        /// <summary>
        /// 类型代码
        /// </summary>
        public const string TYPE_CODE = "typeCode";
        /// <summary>
        /// 类型名称
        /// </summary>
        public const string TYPE_NAME = "typeName";

    }
}
