using System.Threading.Tasks;
using Abp.Application.Services;
using NewDemo.Sessions.Dto;

namespace NewDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
