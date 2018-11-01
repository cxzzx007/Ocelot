namespace Ocelot.Errors
{
    /// <summary>
    /// 错误 抽象类
    /// </summary>
    public abstract class Error 
    {
        protected Error(string message, OcelotErrorCode code)
        {
            Message = message;
            Code = code;
        }

        //错误信息
        public string Message { get; private set; }

        //错误状态码
        public OcelotErrorCode Code { get; private set; }

        //重写此类的ToString方法 返回错误信息
        public override string ToString()
        {
            return Message;
        }
    }
}
