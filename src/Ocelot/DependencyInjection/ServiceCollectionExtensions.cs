using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Ocelot.DependencyInjection
{
    /// <summary>
    /// IServiceCollection扩展方法，用于添加Ocelot服务
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        public static IOcelotBuilder AddOcelot(this IServiceCollection services)
        {
            var service = services.First(x => x.ServiceType == typeof(IConfiguration));//从ServiceCollection中获取配置文件服务
            var configuration = (IConfiguration)service.ImplementationInstance;//ImplementationInstance代表被提供的服务实例，获取配置文件实例
            return new OcelotBuilder(services, configuration);
        }

        public static IOcelotBuilder AddOcelot(this IServiceCollection services, IConfiguration configuration)
        {
            return new OcelotBuilder(services, configuration);
        }
    }
}
