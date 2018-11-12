namespace Ocelot.Configuration
{
    /// <summary>
    /// 下游主机和端口
    /// </summary>
    public class DownstreamHostAndPort
    {
        public DownstreamHostAndPort(string host, int port)
        {
            Host = host;
            Port = port;
        }

        //主机
        public string Host { get; private set; }

        //端口
        public int Port { get; private set; }
    }
}
