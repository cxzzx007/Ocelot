namespace Ocelot.Cache
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Ocelot泛型缓存 实现缓存接口
    /// </summary>
    /// <typeparam name="T">泛型T</typeparam>
    public class InMemoryCache<T> : IOcelotCache<T>
    {
        private readonly Dictionary<string, CacheObject<T>> _cache;
        private readonly Dictionary<string, List<string>> _regions;//region为key value为_cache字典的key列表,value为多个_cache key集合

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryCache{T}"/> class.
        /// 泛型缓存构造函数 初始化缓存字典_cache  初始化区域字典_regions
        /// </summary>
        public InMemoryCache()
        {
            _cache = new Dictionary<string, CacheObject<T>>();
            _regions = new Dictionary<string, List<string>>();
        }

        /// <summary>
        /// 添加key value  和region
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <param name="ttl">多久过期</param>
        /// <param name="region">区域</param>
        public void Add(string key, T value, TimeSpan ttl, string region)
        {
            //过期时间小于0 直接返回
            if (ttl.TotalMilliseconds <= 0)
            {
                return;
            }

            //获取过期时间
            var expires = DateTime.UtcNow.Add(ttl);

            //添加缓存对象
            _cache.Add(key, new CacheObject<T>(value, expires));

            //区域字典里是否有这个区域，有则把_cache的key添加到region的value中
            if (_regions.ContainsKey(region))
            {
                //区域对应的value
                var current = _regions[region];

                //区域value 列表没有这个key  则添加这个key
                if (!current.Contains(key))
                {
                    current.Add(key);
                }
            }

            //没有则添加这个区域
            else
            {
                _regions.Add(region, new List<string>{ key });
            }
        }

        /// <summary>
        /// 有则删除并添加  没有则添加
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// <param name="ttl">多久过期</param>
        /// <param name="region">区域</param>
        public void AddAndDelete(string key, T value, TimeSpan ttl, string region)
        {            
            //缓存字典是否有这个key  有则删除
            if (_cache.ContainsKey(key))
            {
                _cache.Remove(key);
            }

            //添加这个key value和region
            Add(key, value, ttl, region);
        }

        /// <summary>
        /// 清除_cache中，指定region对应的value 
        /// </summary>
        /// <param name="region">region</param>
        public void ClearRegion(string region)
        {
            //region字典是否包含region 包含则清除
            if (_regions.ContainsKey(region))
            {
                //获取region对应的value列表
                var keys = _regions[region];
                foreach (var key in keys)
                {
                    _cache.Remove(key);
                }
            }
        }

        /// <summary>
        /// 获取_cache中key对应的CacheObject中的value
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="region">region</param>
        /// <returns>T</returns>
        public T Get(string key, string region)
        {
            //_cache中有这个key
            if (_cache.ContainsKey(key))
            {
                //获取key对应的CacheObject
                var cached = _cache[key];

                //没有过期 则返回这个CacheObject 过期则删除这个key,返回一个默认对象
                if (cached.Expires > DateTime.UtcNow)
                {
                    return cached.Value;
                }

                _cache.Remove(key);
            }

            return default(T);
        }
    }
}
