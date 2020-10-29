using Microsoft.EntityFrameworkCore;

namespace GenericRepo.EntityFramework
{
  public class DefaultRepository<TModel> : IRepository<TModel> where TModel : class
  {
    private DbContext context;

    public DefaultRepository(DbContext context)
    {
      this.context = context;
    }

    public virtual void Add(TModel instance) => this.context.Set<TModel>().Add(instance);

    public virtual void Remove(TModel instance) => this.context.Set<TModel>().Remove(instance);

    public virtual void Update(TModel instance) => this.context.Set<TModel>().Update(instance);

    public virtual IIncludableQuerySet<TModel> GetAll()
    {
      return new EFIncludableQuerySet<TModel>(this.context.Set<TModel>());
    }
  }
}