using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AG.Pos.Common.Dto;
using AG.Pos.Editions.Dto;

namespace AG.Pos.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}