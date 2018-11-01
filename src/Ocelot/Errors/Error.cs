namespace Ocelot.Errors
{
    /// <summary>
    /// ���� ������
    /// </summary>
    public abstract class Error 
    {
        protected Error(string message, OcelotErrorCode code)
        {
            Message = message;
            Code = code;
        }

        //������Ϣ
        public string Message { get; private set; }

        //����״̬��
        public OcelotErrorCode Code { get; private set; }

        //��д�����ToString���� ���ش�����Ϣ
        public override string ToString()
        {
            return Message;
        }
    }
}
