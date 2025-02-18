﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ITenantService
    {
        void Add(Tenant tenant);
        void AddFromDto(TenantDto tenantDto);
        void Update(Tenant tenant);
        void UpdateFromDto(TenantDto tenantDto);
        void Delete(int id);
        Tenant? GetById(int id);
        List<TenantListDto>? GetAllTenants();
        TenantDetailDto? GetTenantById(int id);
        TenantWithPaymentsDto? GetTenantWithPayments(int id);
        List<PaymentHistoryDto>? GetTenantPayments(int id);
        List<Tenant>? GetByBuildingId(int buildingId);
        List<Tenant>? GetByUserId(int userId);
        Tenant? Get(Expression<Func<Tenant, bool>> filter);
    }
}
