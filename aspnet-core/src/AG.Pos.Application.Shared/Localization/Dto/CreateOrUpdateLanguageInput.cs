using System.ComponentModel.DataAnnotations;

namespace AG.Pos.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}