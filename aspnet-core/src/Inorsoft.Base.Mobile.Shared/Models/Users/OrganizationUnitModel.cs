using Abp.AutoMapper;
using Inorsoft.Base.Organizations.Dto;

namespace Inorsoft.Base.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}