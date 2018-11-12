namespace Ocelot.Configuration
{
    /// <summary>
    /// 限流规则 类
    /// </summary>
    public class RateLimitRule
    {
        public RateLimitRule(string period, double periodTimespan, long limit)
        {
            Period = period;
            PeriodTimespan = periodTimespan;
            Limit = limit;
        }

        // Rate limit period as in 1s, 1m, 1h,1d
        public string Period { get; private set; }

        public double PeriodTimespan { get; private set; }

        // Maximum number of requests that a client can make in a defined period
        public long Limit { get; private set; }
    }
}
