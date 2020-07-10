using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Inorsoft.Base.MultiTenancy.Accounting.Dto;

namespace Inorsoft.Base.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
