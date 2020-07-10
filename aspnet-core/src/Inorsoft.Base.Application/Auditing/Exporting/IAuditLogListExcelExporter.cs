using System.Collections.Generic;
using Inorsoft.Base.Auditing.Dto;
using Inorsoft.Base.Dto;

namespace Inorsoft.Base.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
