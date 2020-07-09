using Abp.Application.Services.Dto;

namespace AG.Pos.Editions.Dto
{
    public class SubscribableEditionComboboxItemDto : ComboboxItemDto
    {
        public bool? IsFree { get; set; }

        public SubscribableEditionComboboxItemDto(string value, string displayText, bool? isFree) : base(value, displayText)
        {
            IsFree = isFree;
        }
    }
}