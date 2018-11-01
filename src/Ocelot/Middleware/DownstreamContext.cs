using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Ocelot.Configuration;
using Ocelot.DownstreamRouteFinder.UrlMatcher;
using Ocelot.Errors;
using Ocelot.Request.Middleware;

namespace Ocelot.Middleware
{
    /// <summary>
    /// 下游 上下文
    /// </summary>
    public class DownstreamContext
    {
        public DownstreamContext(HttpContext httpContext)
        {
            HttpContext = httpContext;
            Errors = new List<Error>();
        }

        public List<PlaceholderNameAndValue> TemplatePlaceholderNameAndValues { get; set; }

        //http 请求上下文
        public HttpContext HttpContext { get; }

        public DownstreamReRoute DownstreamReRoute { get; set; }

        public DownstreamRequest DownstreamRequest { get; set; }

        public DownstreamResponse DownstreamResponse { get; set; }

        public List<Error> Errors { get; }

        public IInternalConfiguration Configuration { get; set; }

        public bool IsError => Errors.Count > 0;
    }
}
