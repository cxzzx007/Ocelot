namespace Ocelot.Headers
{
    using System.Collections.Generic;
    using Ocelot.Configuration;
    using Ocelot.Middleware;
    using Ocelot.Responses;

    /// <summary>
    /// ��Ӧͷ�滻�ӿ�
    /// </summary>
    public interface IHttpResponseHeaderReplacer
    {
        Response Replace(DownstreamContext context, List<HeaderFindAndReplace> fAndRs);
    }
}
