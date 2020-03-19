using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NewDemo.MultiTenancy.Dto;

namespace NewDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

