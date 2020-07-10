using System.Collections.Generic;
using Inorsoft.Base.Chat.Dto;
using Inorsoft.Base.Dto;

namespace Inorsoft.Base.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(List<ChatMessageExportDto> messages);
    }
}
