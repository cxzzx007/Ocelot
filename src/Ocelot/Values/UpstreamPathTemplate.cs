namespace Ocelot.Values
{
    /// <summary>
    /// ����·��ģ��
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

        //ģ��
        public string Template { get; }

        //���ȼ�
        public int Priority { get; }

        //���������ַ���
        public bool ContainsQueryString { get; }

        //ԭʼֵ
        public string OriginalValue { get; }
    }
}
