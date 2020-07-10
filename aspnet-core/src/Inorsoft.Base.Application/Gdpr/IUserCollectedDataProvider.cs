using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Inorsoft.Base.Dto;

namespace Inorsoft.Base.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
