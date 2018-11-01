using System.Collections.Generic;
using System.Net;

namespace Ocelot.Cache
{
    /// <summary>
    /// 缓存响应类
    /// </summary>
    public class CachedResponse
    {
        //构造函数 初始换内部属性
        public CachedResponse(
            HttpStatusCode statusCode,
            Dictionary<string, IEnumerable<string>> headers,
            string body,
            Dictionary<string, IEnumerable<string>> contentHeaders,
            string reasonPhrase
            )
        {
            StatusCode = statusCode;
            Headers = headers ?? new Dictionary<string, IEnumerable<string>>();
            ContentHeaders = contentHeaders ?? new Dictionary<string, IEnumerable<string>>();
            Body = body ?? "";
            ReasonPhrase = reasonPhrase;
        }

        //http状态码
        public HttpStatusCode StatusCode { get; private set; }

        //http头部
        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        //http内容头部
        public Dictionary<string, IEnumerable<string>> ContentHeaders { get; private set; }

        //http正文
        public string Body { get; private set; }
        
        //原因
        public string ReasonPhrase { get; private set; }
    }
}
