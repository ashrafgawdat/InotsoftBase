using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AG.Pos.MultiTenancy
{
    [Table("TenantDomains")]
    public class TenantDomain : FullAuditedEntity, IMustHaveTenant
    {
        public int TenantId { get; set; }

        [Required]
        public virtual string DomainName { get; set; }

        public virtual bool IsActive { get; set; }
    }
}
