namespace Ocelot.Configuration
{
    using System.Collections.Generic;
    using Creator;
    using Values;

    /// <summary>
    /// 下游重路由类
    /// </summary>
    public class DownstreamReRoute
    {
        public DownstreamReRoute(
            string key,
            UpstreamPathTemplate upstreamPathTemplate,
            List<HeaderFindAndReplace> upstreamHeadersFindAndReplace,
            List<HeaderFindAndReplace> downstreamHeadersFindAndReplace,
            List<DownstreamHostAndPort> downstreamAddresses,
            string serviceName,
            HttpHandlerOptions httpHandlerOptions,
            bool useServiceDiscovery,
            bool enableEndpointEndpointRateLimiting,
            QoSOptions qosOptions,
            string downstreamScheme,
            string requestIdKey,
            bool isCached,
            CacheOptions cacheOptions,
            LoadBalancerOptions loadBalancerOptions,
            RateLimitOptions rateLimitOptions,
            Dictionary<string, string> routeClaimsRequirement,
            List<ClaimToThing> claimsToQueries,
            List<ClaimToThing> claimsToHeaders,
            List<ClaimToThing> claimsToClaims,
            bool isAuthenticated,
            bool isAuthorised,
            AuthenticationOptions authenticationOptions,
            DownstreamPathTemplate downstreamPathTemplate,
            string loadBalancerKey,
            List<string> delegatingHandlers,
            List<AddHeader> addHeadersToDownstream,
            List<AddHeader> addHeadersToUpstream,
            bool dangerousAcceptAnyServerCertificateValidator,
            SecurityOptions securityOptions)
        {
            DangerousAcceptAnyServerCertificateValidator = dangerousAcceptAnyServerCertificateValidator;
            AddHeadersToDownstream = addHeadersToDownstream;
            DelegatingHandlers = delegatingHandlers;
            Key = key;
            UpstreamPathTemplate = upstreamPathTemplate;
            UpstreamHeadersFindAndReplace = upstreamHeadersFindAndReplace ?? new List<HeaderFindAndReplace>();
            DownstreamHeadersFindAndReplace = downstreamHeadersFindAndReplace ?? new List<HeaderFindAndReplace>();
            DownstreamAddresses = downstreamAddresses ?? new List<DownstreamHostAndPort>();
            ServiceName = serviceName;
            HttpHandlerOptions = httpHandlerOptions;
            UseServiceDiscovery = useServiceDiscovery;
            EnableEndpointEndpointRateLimiting = enableEndpointEndpointRateLimiting;
            QosOptions = qosOptions;
            DownstreamScheme = downstreamScheme;
            RequestIdKey = requestIdKey;
            IsCached = isCached;
            CacheOptions = cacheOptions;
            LoadBalancerOptions = loadBalancerOptions;
            RateLimitOptions = rateLimitOptions;
            RouteClaimsRequirement = routeClaimsRequirement;
            ClaimsToQueries = claimsToQueries ?? new List<ClaimToThing>();
            ClaimsToHeaders = claimsToHeaders ?? new List<ClaimToThing>();
            ClaimsToClaims = claimsToClaims ?? new List<ClaimToThing>();
            IsAuthenticated = isAuthenticated;
            IsAuthorised = isAuthorised;
            AuthenticationOptions = authenticationOptions;
            DownstreamPathTemplate = downstreamPathTemplate;
            LoadBalancerKey = loadBalancerKey;
            AddHeadersToUpstream = addHeadersToUpstream;
            SecurityOptions = securityOptions;
        }

        public string Key { get; }

        //上游路径模板
        public UpstreamPathTemplate UpstreamPathTemplate { get; }

        //上游头部替换
        public List<HeaderFindAndReplace> UpstreamHeadersFindAndReplace { get; }

        //下游头部替换
        public List<HeaderFindAndReplace> DownstreamHeadersFindAndReplace { get; }

        //下游主机和端口
        public List<DownstreamHostAndPort> DownstreamAddresses { get; }

        //服务名称
        public string ServiceName { get; }

        //http处理选项
        public HttpHandlerOptions HttpHandlerOptions { get; }

        //使用服务发现
        public bool UseServiceDiscovery { get; }

        //使用端口限流
        public bool EnableEndpointEndpointRateLimiting { get; }

        //服务质量选项
        public QoSOptions QosOptions { get; }

        //下游策略
        public string DownstreamScheme { get; }

        //请求id key
        public string RequestIdKey { get; }

        //是否缓存
        public bool IsCached { get; }

        //缓存选项
        public CacheOptions CacheOptions { get; }

        //负载均衡选项
        public LoadBalancerOptions LoadBalancerOptions { get; }

        //限流选项
        public RateLimitOptions RateLimitOptions { get; }
        public Dictionary<string, string> RouteClaimsRequirement { get; }
        public List<ClaimToThing> ClaimsToQueries { get; }
        public List<ClaimToThing> ClaimsToHeaders { get; }
        public List<ClaimToThing> ClaimsToClaims { get; }
        public bool IsAuthenticated { get; }
        public bool IsAuthorised { get; }
        public AuthenticationOptions AuthenticationOptions { get; }
        public DownstreamPathTemplate DownstreamPathTemplate { get; }
        public string LoadBalancerKey { get; }
        public List<string> DelegatingHandlers { get; }

        //下游添加头
        public List<AddHeader> AddHeadersToDownstream { get; }

        //上游添加头
        public List<AddHeader> AddHeadersToUpstream { get; }
        public bool DangerousAcceptAnyServerCertificateValidator { get; }

        //安全选项
        public SecurityOptions SecurityOptions { get; }
    }
}
