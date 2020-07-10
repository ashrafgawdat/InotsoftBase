using System.Threading.Tasks;
using Abp.Application.Services;
using Inorsoft.Base.Editions.Dto;
using Inorsoft.Base.MultiTenancy.Dto;

namespace Inorsoft.Base.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}