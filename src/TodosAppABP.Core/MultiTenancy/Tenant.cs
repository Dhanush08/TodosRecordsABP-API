﻿using Abp.MultiTenancy;
using TodosAppABP.Authorization.Users;

namespace TodosAppABP.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
