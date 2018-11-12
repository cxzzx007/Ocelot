namespace Ocelot.Configuration
{
    /// <summary>
    /// 服务质量选项类
    /// </summary>
    public class QoSOptions
    {
        public QoSOptions(
            int exceptionsAllowedBeforeBreaking, 
            int durationofBreak, 
            int timeoutValue, 
            string key,
            string timeoutStrategy = "Pessimistic")
        {
            ExceptionsAllowedBeforeBreaking = exceptionsAllowedBeforeBreaking;
            DurationOfBreak = durationofBreak;
            TimeoutValue = timeoutValue;
            TimeoutStrategy = timeoutStrategy;
            Key = key;
        }         

        //中断之前 允许多少个异常
        public int ExceptionsAllowedBeforeBreaking { get; }

        //中断时间
        public int DurationOfBreak { get; }

        //超时值
        public int TimeoutValue { get; }

        //超时策略 默认是Pessimistic
        public string TimeoutStrategy { get; }

        //使用服务质量选项  允许异常大于0 或者 超时值大于0 时
        public bool UseQos => ExceptionsAllowedBeforeBreaking > 0 || TimeoutValue > 0;

        public string Key { get; }
    }
}
