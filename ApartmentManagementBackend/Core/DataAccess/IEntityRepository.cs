﻿using Core.Concrete;
using System.Linq.Expressions;

public interface IEntityRepository<T> where T : class,IEntity, new()
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    T Get(Expression<Func<T, bool>> filter);
    List<T> GetAll(Expression<Func<T, bool>> filter = null);
}
