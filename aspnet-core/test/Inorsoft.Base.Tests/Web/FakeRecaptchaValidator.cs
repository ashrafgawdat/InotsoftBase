using System.Threading.Tasks;
using Inorsoft.Base.Security.Recaptcha;

namespace Inorsoft.Base.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
