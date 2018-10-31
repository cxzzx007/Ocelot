using System;

namespace Ocelot.Cache
{
    /// <summary>
    /// Ocelot缓存接口
    /// </summary>
    /// <typeparam name="T">泛型缓存 类型</typeparam>
    public interface IOcelotCache<T>
    {
        void Add(string key, T value, TimeSpan ttl, string region);
        T Get(string key, string region);
        void ClearRegion(string region);
        void AddAndDelete(string key, T value, TimeSpan ttl, string region);
    }
}
