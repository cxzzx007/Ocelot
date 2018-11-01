using System.Net.Http;
using Ocelot.Request.Middleware;
using Ocelot.Responses;

namespace Ocelot.Infrastructure
{
    /// <summary>
    /// ռλ���ӿ�
    /// </summary>
    public interface IPlaceholders
    {
        //���key ����һ��Response<string>
        Response<string> Get(string key);

        //���key DownstreamRequest ����һ��Response<string>
        Response<string> Get(string key, DownstreamRequest request);
    }
}
