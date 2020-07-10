using System.ComponentModel.DataAnnotations;

namespace Inorsoft.Base.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}