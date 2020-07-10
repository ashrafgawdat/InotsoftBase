using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Inorsoft.Base.Common.Dto;
using Inorsoft.Base.Editions.Dto;

namespace Inorsoft.Base.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}