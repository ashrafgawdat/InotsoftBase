using System.Threading.Tasks;
using Abp.Dependency;

namespace Inorsoft.Base.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}