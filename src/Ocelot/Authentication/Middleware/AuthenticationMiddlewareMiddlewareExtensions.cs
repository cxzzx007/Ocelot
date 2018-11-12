using Ocelot.Middleware.Pipeline;

namespace Ocelot.Authentication.Middleware
{
    /// <summary>
    /// IOcelotPipelineBuilder��չ���� ���AuthenticationMiddleware
    /// </summary>
    public static class AuthenticationMiddlewareMiddlewareExtensions
    {
        public static IOcelotPipelineBuilder UseAuthenticationMiddleware(this IOcelotPipelineBuilder builder)
        {
            return builder.UseMiddleware<AuthenticationMiddleware>();
        }
    }
}
