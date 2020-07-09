using System.Threading.Tasks;
using Abp.Application.Services;
using AG.Pos.Editions.Dto;
using AG.Pos.MultiTenancy.Dto;

namespace AG.Pos.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}