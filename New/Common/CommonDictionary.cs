namespace New.Common
{
    public class CommonDictionary : NotificationObject
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
        /// 值代码
        /// </summary>
        private string _valueCode;
        public string valueCode
        {
            get { return _valueCode; }
            set
            {
                if (_valueCode != value)
                {
                    _valueCode = value;
                    RaisePropertyChanged("valueCode");
                }
            }
        }

        /// <summary>
        /// 值名称
        /// </summary>
        private string _valueName;
        public string valueName
        {
            get { return _valueName; }
            set
            {
                if (_valueName != value)
                {
                    _valueName = value;
                    RaisePropertyChanged("valueName");
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
        /// <summary>
        /// 值代码
        /// </summary>
        public const string VALUE_CODE = "valueCode";
        /// <summary>
        /// 值名称
        /// </summary>
        public const string VALUE_NAME = "valueName";

    }
}
