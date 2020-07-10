using System.Collections.Generic;
using Inorsoft.Base.Authorization.Users.Dto;
using Inorsoft.Base.Dto;

namespace Inorsoft.Base.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}