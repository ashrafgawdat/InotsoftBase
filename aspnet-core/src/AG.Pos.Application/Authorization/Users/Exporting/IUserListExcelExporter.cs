using System.Collections.Generic;
using AG.Pos.Authorization.Users.Dto;
using AG.Pos.Dto;

namespace AG.Pos.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}