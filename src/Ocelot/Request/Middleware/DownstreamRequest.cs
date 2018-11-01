namespace Ocelot.Request.Middleware
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;

    /// <summary>
    /// ����������
    /// </summary>
    public class DownstreamRequest
    {
        //http������Ϣ
        private readonly HttpRequestMessage _request;

        public DownstreamRequest(HttpRequestMessage request)
        {
            _request = request;
            Method = _request.Method.Method;//����ķ��� GET
            OriginalString = _request.RequestUri.OriginalString;//�����url    http://localhost:5056/api/values?t=1&s=2
            Scheme = _request.RequestUri.Scheme;//����Э��  http
            Host = _request.RequestUri.Host;//���������� localhost
            Port = _request.RequestUri.Port;//����˿�  5056
            Headers = _request.Headers;//����ͷ    Cache-Control: max-age=0\r\nConnection�ȵ�
            AbsolutePath = _request.RequestUri.AbsolutePath;//�����ҳ�����·��   /api/values
            Query = _request.RequestUri.Query;//���������  ?t=1&s=2
        }

        public HttpRequestHeaders Headers { get; }

        public string Method { get; }

        public string OriginalString { get; }

        public string Scheme { get; set; }

        public string Host { get; set; }

        public int Port { get; set; }

        public string AbsolutePath { get; set; }

        public string Query { get; set; }

        //���������� ת��ΪHttpRequestMessage
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

        //���������� ת��ΪUri
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
