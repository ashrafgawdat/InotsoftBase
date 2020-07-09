﻿using Abp.AutoMapper;
using AG.Pos.Organizations.Dto;

namespace AG.Pos.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}