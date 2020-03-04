﻿namespace Domain.Tenants.Multitenancy
{
    public interface ITenantAccessor<T> where T : Tenant
    {
        T Tenant { get; }
    }
}
