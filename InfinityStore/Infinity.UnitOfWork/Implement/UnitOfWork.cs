using Infinity.Data;
using Infinity.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private InfinityStoreDBContext _context;

        public UnitOfWork(InfinityStoreDBContext context)
        {
            _context = context;
            InitRepositories();
        }
        private void InitRepositories()
        {
            CategoryRepository = new GenericRepository<Categories>(_context);
            //PropertyRepository = new GenericRepository<Properties>(_context);
            //ProductRepository = new GenericRepository<Products>(_context);
            //ProductPropertyRepository = new GenericRepository<ProductProperties>(_context);
            //ProductInstanceRepository = new GenericRepository<ProductInstances>(_context);
        }

        private bool disposedValue = false;

        public IGenericRepository<Categories> CategoryRepository { get; private set; }

        //public IGenericRepository<Properties> PropertyRepository { get; private set; }

        //public IGenericRepository<Products> ProductRepository { get; private set; }

        //public IGenericRepository<ProductProperties> ProductPropertyRepository { get; private set; }

        //public IGenericRepository<ProductInstances> ProductInstanceRepository { get; private set; }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
