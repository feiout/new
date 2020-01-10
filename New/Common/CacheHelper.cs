using System.Collections.Generic;
using System.Collections.ObjectModel;
using New.RestUtility;
using New.Service;

namespace New.Common
{
    public static class CacheHelper
    {
        private static readonly DictionariesService DictionaryService = ServiceHelper<DictionariesService>.CreateInterface();

        public static ObservableCollection<CommonDictionary> GetCommonDictionaryList(string dictionaryType)
        {
            const string cacheGroup = "CommonDictionary";

            if (!StaticCacheHelper<ObservableCollection<CommonDictionary>>.Contains(cacheGroup, dictionaryType))
            {
                var conditions = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>(CommonDictionary.TYPE_CODE, dictionaryType),
                    };
                var commonDictionaries = DictionaryService.GetCommonDictionaryList(conditions);
                StaticCacheHelper<ObservableCollection<CommonDictionary>>.Set(cacheGroup, dictionaryType, commonDictionaries);
                return commonDictionaries;
            }
            return StaticCacheHelper<ObservableCollection<CommonDictionary>>.Get(cacheGroup, dictionaryType);
        }

    }
}
