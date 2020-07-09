using System.Collections.Generic;
using AG.Pos.Chat.Dto;
using AG.Pos.Dto;

namespace AG.Pos.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(List<ChatMessageExportDto> messages);
    }
}
