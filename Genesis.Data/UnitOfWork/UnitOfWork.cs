using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Data.UnitOfWork
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly GenesisContext _genesisContext;
        public UnitOfWork(GenesisContext genesisContext) {

            _genesisContext = genesisContext;
        } 
        public int SaveChanges()
        {
            return _genesisContext.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _genesisContext.SaveChangesAsync();
        }
    }
}
