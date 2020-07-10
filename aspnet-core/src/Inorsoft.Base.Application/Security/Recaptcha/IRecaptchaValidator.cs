using System.Threading.Tasks;

namespace Inorsoft.Base.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}