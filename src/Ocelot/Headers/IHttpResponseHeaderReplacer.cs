namespace Ocelot.Headers
{
    using System.Collections.Generic;
    using Ocelot.Configuration;
    using Ocelot.Middleware;
    using Ocelot.Responses;

    /// <summary>
    /// 响应头替换接口
    /// </summary>
    public interface IHttpResponseHeaderReplacer
    {
        Response Replace(DownstreamContext context, List<HeaderFindAndReplace> fAndRs);
    }
}
