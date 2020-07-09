using System.ComponentModel.DataAnnotations;

namespace AG.Pos.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}