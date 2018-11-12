namespace Ocelot.Values
{
    /// <summary>
    /// 上游路径模板
    /// </summary>
    public class UpstreamPathTemplate
    {
        public UpstreamPathTemplate(string template, int priority, bool containsQueryString, string originalValue)
        {
            Template = template;
            Priority = priority;
            ContainsQueryString = containsQueryString;
            OriginalValue = originalValue;
        }

        //模板
        public string Template { get; }

        //优先级
        public int Priority { get; }

        //包含请求字符串
        public bool ContainsQueryString { get; }

        //原始值
        public string OriginalValue { get; }
    }
}
