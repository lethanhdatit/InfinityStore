using Infinity.Data;
using Infinity.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Categories> CategoryRepository { get; }
        IGenericRepository<Properties> PropertyRepository { get; }
        IGenericRepository<Products> ProductRepository { get; }
        IGenericRepository<ProductProperties> ProductPropertyRepository { get; }
        IGenericRepository<ProductInstances> ProductInstanceRepository { get; }

        Task<int> SaveChangesAsync();
        void SaveChanges();
    }
}
