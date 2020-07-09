using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AG.Pos.Editions.Dto;

namespace AG.Pos.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}