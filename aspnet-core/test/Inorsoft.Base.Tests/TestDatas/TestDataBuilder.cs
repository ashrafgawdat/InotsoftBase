﻿using Inorsoft.Base.EntityFrameworkCore;

namespace Inorsoft.Base.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly PosDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(PosDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();
            new TestEditionsBuilder(_context).Create();

            _context.SaveChanges();
        }
    }
}
