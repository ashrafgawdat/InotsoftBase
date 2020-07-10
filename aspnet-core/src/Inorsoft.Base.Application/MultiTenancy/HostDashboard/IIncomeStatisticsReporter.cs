using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Inorsoft.Base.MultiTenancy.HostDashboard.Dto;

namespace Inorsoft.Base.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}