using System.Collections.Generic;
using AG.Pos.Auditing.Dto;
using AG.Pos.Dto;

namespace AG.Pos.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
