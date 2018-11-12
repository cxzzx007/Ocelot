namespace Ocelot.Configuration
{
    /// <summary>
    /// 缓存选项类
    /// </summary>
    public class CacheOptions
    {
        public CacheOptions(int ttlSeconds, string region)
        {
            TtlSeconds = ttlSeconds;
            Region = region;
        }
        
        //缓存时间
        public int TtlSeconds { get; private set; }

        //区域
        public string Region { get; private set; }
    }
}
