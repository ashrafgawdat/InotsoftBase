using System.Threading.Tasks;
using AG.Pos.Security.Recaptcha;

namespace AG.Pos.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
