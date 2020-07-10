using System.Threading.Tasks;
using Abp.Application.Services;

namespace Inorsoft.Base.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task UpgradeTenantToEquivalentEdition(int upgradeEditionId);
    }
}
