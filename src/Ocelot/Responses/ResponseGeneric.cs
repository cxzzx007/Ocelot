using System.Collections.Generic;
using Ocelot.Errors;

namespace Ocelot.Responses
{
    /// <summary>
    /// ��Ӧ������� �̳�����Ӧ������
    /// </summary>
    /// <typeparam name="T">����T</typeparam>
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

        //���͵�ʵ��
        public T Data { get; private set; }        
    }
} 
