namespace Ocelot.Configuration
{
    using System.Collections.Generic;
    using Creator;
    using Values;

    /// <summary>
    /// ������·����
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

        //����·��ģ��
        public UpstreamPathTemplate UpstreamPathTemplate { get; }

        //����ͷ���滻
        public List<HeaderFindAndReplace> UpstreamHeadersFindAndReplace { get; }

        //����ͷ���滻
        public List<HeaderFindAndReplace> DownstreamHeadersFindAndReplace { get; }

        //���������Ͷ˿�
        public List<DownstreamHostAndPort> DownstreamAddresses { get; }

        //��������
        public string ServiceName { get; }

        //http����ѡ��
        public HttpHandlerOptions HttpHandlerOptions { get; }

        //ʹ�÷�����
        public bool UseServiceDiscovery { get; }

        //ʹ�ö˿�����
        public bool EnableEndpointEndpointRateLimiting { get; }

        //��������ѡ��
        public QoSOptions QosOptions { get; }

        //���β���
        public string DownstreamScheme { get; }

        //����id key
        public string RequestIdKey { get; }

        //�Ƿ񻺴�
        public bool IsCached { get; }

        //����ѡ��
        public CacheOptions CacheOptions { get; }

        //���ؾ���ѡ��
        public LoadBalancerOptions LoadBalancerOptions { get; }

        //����ѡ��
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

        //�������ͷ
        public List<AddHeader> AddHeadersToDownstream { get; }

        //�������ͷ
        public List<AddHeader> AddHeadersToUpstream { get; }
        public bool DangerousAcceptAnyServerCertificateValidator { get; }

        //��ȫѡ��
        public SecurityOptions SecurityOptions { get; }
    }
}
