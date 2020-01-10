using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using New.Common;

namespace New.Base
{
    public sealed class DictionaryHelper
    {
        public static readonly DictionaryHelper Instance = new DictionaryHelper();
        private List<string> Keys { get; set; }
        private Dictionary<string, ObservableCollection<CommonDictionary>> Values { get; set; }

        public ObservableCollection<CommonDictionary> this[string key]
        {
            get
            {
                var commonDictionaries = Keys.Contains(key) && Values.ContainsKey(key) ? Values[key] : null;
                if (commonDictionaries == null)
                {
                    commonDictionaries = CacheHelper.GetCommonDictionaryList(key);
                    Keys.Add(key);
                    Values[key] = commonDictionaries;
                }
                return commonDictionaries;
            }
            set { Values[key] = value; }
        }

        public string this[string key, string code]
        {
            get
            {
                var dic = Keys.Contains(key) && Values.ContainsKey(key) ? Values[key] : null;
                if (dic != null)
                {
                    var dicItem = dic.FirstOrDefault(entity => entity.valueCode == code);
                    return dicItem != null ? dicItem.valueName : string.Empty;
                }
                return string.Empty;
            }
        }
    }
}
