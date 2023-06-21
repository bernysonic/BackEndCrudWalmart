using AutoMapper;
using BackEndCrudWalmart.DTOs;
using BackEndCrudWalmart.Models;
using System.Globalization;

namespace BackEndCrudWalmart.Utilidades
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Cat_product
            CreateMap<AtCatProduct, Cat_Product_DTO>().ReverseMap();
            #endregion
        }
    }
}
