using Infinity.Data;
using Infinity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Services
{
    public interface IProductService : IBaseService<Products, ProductsDto>
    {
        Task SubmitAsync(long createBy, ProductsDto product);
        IEnumerable<ProductsDto> GetAllActive();
    }
}
