namespace Ocelot.Request.Middleware
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;

    /// <summary>
    /// 下游请求类
    /// </summary>
    public class DownstreamRequest
    {
        //http请求信息
        private readonly HttpRequestMessage _request;

        public DownstreamRequest(HttpRequestMessage request)
        {
            _request = request;
            Method = _request.Method.Method;//请求的方法 GET
            OriginalString = _request.RequestUri.OriginalString;//请求的url    http://localhost:5056/api/values?t=1&s=2
            Scheme = _request.RequestUri.Scheme;//请求协议  http
            Host = _request.RequestUri.Host;//请求主机名 localhost
            Port = _request.RequestUri.Port;//请求端口  5056
            Headers = _request.Headers;//请求头    Cache-Control: max-age=0\r\nConnection等等
            AbsolutePath = _request.RequestUri.AbsolutePath;//请求的页面绝对路径   /api/values
            Query = _request.RequestUri.Query;//请求的内容  ?t=1&s=2
        }

        public HttpRequestHeaders Headers { get; }

        public string Method { get; }

        public string OriginalString { get; }

        public string Scheme { get; set; }

        public string Host { get; set; }

        public int Port { get; set; }

        public string AbsolutePath { get; set; }

        public string Query { get; set; }

        //将下游请求 转换为HttpRequestMessage
        public HttpRequestMessage ToHttpRequestMessage()
        {
            var uriBuilder = new UriBuilder
            {
                Port = Port,
                Host = Host,
                Path = AbsolutePath,
                Query = Query,
                Scheme = Scheme
            };

            _request.RequestUri = uriBuilder.Uri;
            return _request;
        }

        //将下游请求 转换为Uri
        public string ToUri()
        {
            var uriBuilder = new UriBuilder
            {
                Port = Port,
                Host = Host,
                Path = AbsolutePath,
                Query = Query,
                Scheme = Scheme
            };

            return uriBuilder.Uri.AbsoluteUri;
        }

        public override string ToString() 
        {
            return ToUri();
        }
    }
}
