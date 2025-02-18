﻿using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IBuildingDal : IEntityRepository<Building>
    {
        // Özel sorgular için metotlar eklenebilir
    }
}
