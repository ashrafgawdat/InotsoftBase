using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Inorsoft.Base.Editions.Dto;

namespace Inorsoft.Base.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}