using Infinity.Data;
using Infinity.DTOs;
using Infinity.Repositories;
using Infinity.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Services
{
    public class ProductService : BaseService<Products, ProductsDto>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IGenericRepository<Products> _reponsitory => _unitOfWork.ProductRepository;

        public IEnumerable<ProductsDto> GetAllActive()
        {
            var entities = _unitOfWork.ProductRepository.Find(x => x.Status == 1);
            return EntityToDto(entities);
        }

        public async Task SubmitAsync(long createBy, ProductsDto productDto)
        {
            productDto.CreatedBy = createBy;
            productDto.CreatedTs = DateTime.UtcNow;
            //await CreateAsync(productDto);
            _unitOfWork.ProductRepository.Add(DtoToEntity(productDto));
            _unitOfWork.SaveChanges();
        }
    }
}
