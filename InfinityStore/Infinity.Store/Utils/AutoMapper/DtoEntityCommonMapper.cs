using AutoMapper;
using Infinity.Data;
using Infinity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infinity.Store
{
    public class DtoEntityCommonMapper : Profile
    {
        public DtoEntityCommonMapper()
        {
            #region Enity To Dto

            CreateMap<Products, ProductsDto>();

            #endregion

            #region Dto to Entity

            CreateMap<ProductsDto, Products>();

            #endregion
        }
    }
}
