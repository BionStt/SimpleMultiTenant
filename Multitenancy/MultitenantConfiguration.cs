﻿using System.Collections.Generic;

namespace Multitenancy
{
    public class MultitenantConfiguration
    {
        public string DefaultTenant { get; set; }
        public List<Tenant> Tenants { get; set; }
    }
}
