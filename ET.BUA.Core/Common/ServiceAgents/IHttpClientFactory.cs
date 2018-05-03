using System.Net.Http;
using  ET.Core.ServiceAgents.Settings;

namespace ET.Core.ServiceAgents
{
    public interface IHttpClientFactory
    {
        HttpClient CreateClient(ServiceAgentSettings serviceAgentSettings, ServiceSettings settings);
    }
}