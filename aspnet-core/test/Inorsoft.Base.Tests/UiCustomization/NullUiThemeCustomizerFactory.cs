using System.Threading.Tasks;
using Inorsoft.Base.UiCustomization;

namespace Inorsoft.Base.Tests.UiCustomization
{
    public class NullUiThemeCustomizerFactory : IUiThemeCustomizerFactory
    {
        public async Task<IUiCustomizer> GetCurrentUiCustomizer()
        {
            return new NullThemeUiCustomizer();
        }

        public IUiCustomizer GetUiCustomizer(string theme)
        {
            return new NullThemeUiCustomizer();
        }
    }
}
