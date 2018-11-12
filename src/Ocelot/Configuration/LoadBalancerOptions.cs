using Ocelot.LoadBalancer.LoadBalancers;

namespace Ocelot.Configuration
{
    /// <summary>
    /// ���ؾ���ѡ����
    /// </summary>
    public class LoadBalancerOptions
    {
        public LoadBalancerOptions(string type, string key, int expiryInMs)
        {
            Type = type ?? nameof(NoLoadBalancer);
            Key = key;
            ExpiryInMs = expiryInMs;
        }

        //���� ������ΪNoLoadBalancer
        public string Type { get; }

        public string Key { get; }
        
        //����ms������ֹ��
        public int ExpiryInMs { get; } 
    }
}
