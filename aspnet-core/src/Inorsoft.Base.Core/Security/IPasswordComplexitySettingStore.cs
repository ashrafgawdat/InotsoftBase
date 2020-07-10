using System.Threading.Tasks;

namespace Inorsoft.Base.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
