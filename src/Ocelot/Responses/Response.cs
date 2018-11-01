using System.Collections.Generic;
using Ocelot.Errors;

namespace Ocelot.Responses
{
    /// <summary>
    /// ��Ӧ������
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

        //������б�
        public List<Error> Errors { get; }

        //�����б��Ƿ���ֵ
        public bool IsError => Errors.Count > 0;
    }
}
