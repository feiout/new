using System;
using System.Collections.Generic;

namespace New.Common
{
    public static class StaticCacheHelper<T>
    {
        private static readonly Dictionary<string, Dictionary<string, T>> CacheGroup =
            new Dictionary<string, Dictionary<string, T>>();

        private const string DefaultCacheGroup = "Default";

        /// <summary>
        /// 判断默认缓存中是否包含Key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool Contains(string key)
        {
            if (CacheGroup.ContainsKey(DefaultCacheGroup))
            {
                var mCache = CacheGroup[DefaultCacheGroup];
                return mCache.ContainsKey(key);
            }
            return false;
        }

        /// <summary>
        /// 判断在指定缓存中是否包含Key
        /// </summary>
        /// <param name="cacheGroup"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool Contains(string cacheGroup, string key)
        {
            if (CacheGroup.ContainsKey(cacheGroup))
            {
                var mCache = CacheGroup[cacheGroup];
                return mCache.ContainsKey(key);
            }
            return false;
        }

        /// <summary>
        /// 根据Key获取默认分组中的缓存对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Get(string key)
        {
            if (CacheGroup.ContainsKey(DefaultCacheGroup))
            {
                var mCache = CacheGroup[DefaultCacheGroup];
                if (mCache.ContainsKey(key))
                {
                    return mCache[key];
                }
            }
            return Activator.CreateInstance<T>();
        }

        /// <summary>
        /// 根据Key在默认分组中缓存对象
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Set(string key, T value)
        {
            if (!CacheGroup.ContainsKey(DefaultCacheGroup))
            {
                CacheGroup.Add(DefaultCacheGroup, new Dictionary<string, T>());
            }
            var mCache = CacheGroup[DefaultCacheGroup];
            if (mCache.ContainsKey(key))
            {
                mCache[key] = value;
            }
            else
            {
                mCache.Add(key, value);
            }
        }

        /// <summary>
        /// 根据Key获取指定分组中的缓存对象
        /// </summary>
        /// <param name="cacheGroup"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Get(string cacheGroup, string key)
        {
            if (CacheGroup.ContainsKey(cacheGroup))
            {
                var mCache = CacheGroup[cacheGroup];
                if (mCache.ContainsKey(key))
                {
                    return mCache[key];
                }
            }
            return Activator.CreateInstance<T>();
        }

        /// <summary>
        /// 根据Key在指定分组中缓存对象
        /// </summary>
        /// <param name="cacheGroup"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Set(string cacheGroup, string key, T value)
        {
            if (!CacheGroup.ContainsKey(cacheGroup))
            {
                CacheGroup.Add(cacheGroup, new Dictionary<string, T>());
            }
            var mCache = CacheGroup[cacheGroup];
            if (mCache.ContainsKey(key))
            {
                mCache[key] = value;
            }
            else
            {
                mCache.Add(key, value);
            }
        }
        /// <summary>
        /// 根据Key在默认分组中移除缓存对象
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Remove(string key, T value)
        {
            if (!CacheGroup.ContainsKey(DefaultCacheGroup))
            {
                return;
            }
            var mCache = CacheGroup[DefaultCacheGroup];
            if (mCache.ContainsKey(key))
            {
                mCache.Remove(key);
            }

        }

        /// <summary>
        /// 根据Key移除指定分组中的缓存对象
        /// </summary>
        /// <param name="cacheGroup"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static void Remove(string cacheGroup, string key)
        {
            if (!CacheGroup.ContainsKey(cacheGroup))
            {
                return;
            }
            var mCache = CacheGroup[cacheGroup];
            if (mCache.ContainsKey(key))
            {
                mCache.Remove(key);
            }

        }
    }
}
