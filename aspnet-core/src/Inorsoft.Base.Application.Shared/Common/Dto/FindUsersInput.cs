using Inorsoft.Base.Dto;

namespace Inorsoft.Base.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}