using Ocelot.LoadBalancer.LoadBalancers;

namespace Ocelot.Configuration
{
    /// <summary>
    /// 负载均衡选项类
    /// </summary>
    public class LoadBalancerOptions
    {
        public LoadBalancerOptions(string type, string key, int expiryInMs)
        {
            Type = type ?? nameof(NoLoadBalancer);
            Key = key;
            ExpiryInMs = expiryInMs;
        }

        //类型 若空则为NoLoadBalancer
        public string Type { get; }

        public string Key { get; }
        
        //多少ms毫秒终止？
        public int ExpiryInMs { get; } 
    }
}
