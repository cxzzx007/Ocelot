namespace Ocelot.Configuration.Creator
{
    /// <summary>
    /// ���ͷ ��
    /// </summary>
    public class AddHeader
    {
        public AddHeader(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; }
        public string Value { get; }
    }
}
