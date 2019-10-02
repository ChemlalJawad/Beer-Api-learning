using System.Threading.Tasks;

namespace Genesis.Data.UnitOfWork
{
   public interface IUnitOfWork
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
