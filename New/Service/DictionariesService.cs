using System.Collections.Generic;
using System.Collections.ObjectModel;
using New.Common;
using New.RestUtility;

namespace New.Service
{
    public class DictionariesService
    {
        #region Const Url

        private const string CommonDictionaryType = "/dictionary/type";

        private const string CommonDictionary = "/dictionary";

        private const string CommonDictionaryBatchUpdate = "/dictionary/updateByType";

        #endregion

        public ObservableCollection<CommonDictionaryType> GetAllCommonDictionaryTypeList(List<KeyValuePair<string, string>> conditions)
        {
            return RestHelper.Get<ObservableCollection<CommonDictionaryType>>(CommonDictionaryType, conditions);
        }

        public ObservableCollection<CommonDictionary> GetCommonDictionaryList(List<KeyValuePair<string, string>> conditions)
        {
            return RestHelper.Get<ObservableCollection<CommonDictionary>>(CommonDictionary, conditions);
        }

        public bool SubmitCommonDictionaries(ObservableCollection<CommonDictionary> commonDictionaries)
        {
            return RestHelper.Put(CommonDictionaryBatchUpdate, commonDictionaries);
        }

    }
}
