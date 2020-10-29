using System;
using System.Linq.Expressions;

namespace GenericRepo
{
  public interface IIncludableQuerySet<TEntity> : IQuerySet<TEntity> where TEntity : class
  {
    IThenIncludableQuerySet<TEntity, TProperty> Include<TProperty>(Expression<Func<TEntity, TProperty>> include) where TProperty : class;
  }
}