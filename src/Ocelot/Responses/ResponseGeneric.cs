using System.Collections.Generic;
using Ocelot.Errors;

namespace Ocelot.Responses
{
    /// <summary>
    /// 响应类抽象类 继承自响应抽象类
    /// </summary>
    /// <typeparam name="T">泛型T</typeparam>
#pragma warning disable SA1649 // File name must match first type name
    public abstract class Response<T> : Response
#pragma warning restore SA1649 // File name must match first type name
    {
        protected Response(T data)
        {
            Data = data;
        }

        protected Response(List<Error> errors) : base(errors)
        {
        }

        //泛型的实体
        public T Data { get; private set; }        
    }
} 
