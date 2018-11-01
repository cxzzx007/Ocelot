using System.Net.Http;
using Ocelot.Request.Middleware;
using Ocelot.Responses;

namespace Ocelot.Infrastructure
{
    /// <summary>
    /// 占位符接口
    /// </summary>
    public interface IPlaceholders
    {
        //入参key 返回一个Response<string>
        Response<string> Get(string key);

        //入参key DownstreamRequest 返回一个Response<string>
        Response<string> Get(string key, DownstreamRequest request);
    }
}
