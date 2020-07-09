using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using AG.Pos.MultiTenancy.Accounting.Dto;

namespace AG.Pos.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
