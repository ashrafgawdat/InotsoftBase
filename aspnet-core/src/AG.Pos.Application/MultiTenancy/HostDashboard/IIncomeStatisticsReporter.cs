using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AG.Pos.MultiTenancy.HostDashboard.Dto;

namespace AG.Pos.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}