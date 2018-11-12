using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ocelot.Configuration
{
    /// <summary>
    /// RateLimit Options
    /// </summary>
    public class RateLimitOptions
    {
        public RateLimitOptions(bool enbleRateLimiting, string clientIdHeader, List<string> clientWhitelist,bool disableRateLimitHeaders,
            string quotaExceededMessage, string rateLimitCounterPrefix, RateLimitRule rateLimitRule, int httpStatusCode)
        {
            EnableRateLimiting = enbleRateLimiting;
            ClientIdHeader = clientIdHeader;
            ClientWhitelist = clientWhitelist?? new List<string>();
            DisableRateLimitHeaders = disableRateLimitHeaders;
            QuotaExceededMessage = quotaExceededMessage;
            RateLimitCounterPrefix = rateLimitCounterPrefix;
            RateLimitRule = rateLimitRule;
            HttpStatusCode = httpStatusCode;
        }

        //限流规则
        public RateLimitRule RateLimitRule { get;  private set; }

        //白名单
        public List<string> ClientWhitelist { get; private set; }
   
        // Gets or sets the HTTP header that holds the client identifier, by default is X-ClientId
        public string ClientIdHeader { get; private set; }  

        // Gets or sets the HTTP Status code returned when rate limiting occurs, by default value is set to 429 (Too Many Requests)
        public int HttpStatusCode { get; private set; } 

        // Gets or sets a value that will be used as a formatter for the QuotaExceeded response message.
        // If none specified the default will be: 
        // API calls quota exceeded! maximum admitted {0} per {1}
        public string QuotaExceededMessage { get; private set; }

        // Gets or sets the counter prefix, used to compose the rate limit counter cache key
        public string RateLimitCounterPrefix { get; private set; }  

        // Enables endpoint rate limiting based URL path and HTTP verb
        public bool EnableRateLimiting { get; private set; }

        // Disables X-Rate-Limit and Rety-After headers
        public bool DisableRateLimitHeaders { get; private set; }
    }
}
