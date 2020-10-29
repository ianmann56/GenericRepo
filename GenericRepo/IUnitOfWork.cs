using System.Threading.Tasks;

namespace GenericRepo
{
  public interface IUnitOfWork
  {
    IRepository<T> GetRepository<T>() where T : class;
    Task SaveChangesAsync();
  }
}