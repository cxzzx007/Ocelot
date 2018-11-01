using System.Collections.Generic;
using Ocelot.Errors;

namespace Ocelot.Responses
{
    /// <summary>
    /// 响应抽象类
    /// </summary>
    public abstract class Response
    {
        protected Response()
        {
            Errors = new List<Error>();
        }

        protected Response(List<Error> errors)
        {
            Errors = errors ?? new List<Error>();
        } 

        //错误的列表
        public List<Error> Errors { get; }

        //错误列表是否有值
        public bool IsError => Errors.Count > 0;
    }
}
