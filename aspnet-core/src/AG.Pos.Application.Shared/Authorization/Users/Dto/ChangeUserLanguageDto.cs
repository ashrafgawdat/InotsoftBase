using System.ComponentModel.DataAnnotations;

namespace AG.Pos.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
