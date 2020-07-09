using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using AG.Pos.Dto;

namespace AG.Pos.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
