using System.Threading.Tasks;
using  ET.Core.ServiceAgents.Models;
using  ET.Core.ServiceAgents.Settings;

namespace ET.Core.ServiceAgents.OAuth
{
    public interface ITokenHelper
    {
        Task<TokenReply> ReadOrRetrieveToken(ServiceSettings options);
    }
}