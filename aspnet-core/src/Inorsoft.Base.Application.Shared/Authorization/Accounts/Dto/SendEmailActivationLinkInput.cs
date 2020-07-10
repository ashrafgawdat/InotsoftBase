using System.ComponentModel.DataAnnotations;

namespace Inorsoft.Base.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}