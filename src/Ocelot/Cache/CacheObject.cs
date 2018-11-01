namespace Ocelot.Cache
{
    using System;

    /// <summary>
    /// 缓存对象
    /// </summary>
    /// <typeparam name="T">缓存对象 对象的值 对象的过期时间</typeparam>
    class CacheObject<T>
    {
        public CacheObject(T value, DateTime expires)
        {
            Value = value;
            Expires = expires;
        }

        //缓存对象
        public T Value { get; }

        //过期时间
        public DateTime Expires { get; }
    }
}
