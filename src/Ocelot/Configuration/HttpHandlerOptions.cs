namespace Ocelot.Configuration
{
    /// <summary>
    /// Describes configuration parameters for http handler, 
    /// that is created to handle a request to service
    /// http处理选项类
    /// </summary>
    public class HttpHandlerOptions
    {
        public HttpHandlerOptions(bool allowAutoRedirect, bool useCookieContainer, bool useTracing, bool useProxy)
        {
            AllowAutoRedirect = allowAutoRedirect;
            UseCookieContainer = useCookieContainer;
            UseTracing = useTracing;
            UseProxy = useProxy;
        }

        /// <summary>
        /// Specify if auto redirect is enabled
        /// 允许自动重定向
        /// </summary>
        public bool AllowAutoRedirect { get; private set; }

        /// <summary>
        /// Specify is handler has to use a cookie container
        /// 使用cookie容器
        /// </summary>
        public bool UseCookieContainer { get; private set; }

        /// <summary>
        /// Specify is handler has to use a opentracing
        /// 使用跟踪
        /// </summary>
        public bool UseTracing { get; private set; }

        /// <summary>
        /// Specify if handler has to use a proxy
        /// 使用代理
        /// </summary>
        public bool UseProxy { get; private set; }
    }
}
