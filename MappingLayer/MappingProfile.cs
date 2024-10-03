using AutoMapper;
using LibDAL;
using LibDTO;

namespace MappingLayer
{
    public class MappingProfile : Profile
    {
        // ánh xạ DTO -> ENTIRY
        public MappingProfile()
        {
            CreateMap<UserAccountDTO, user_account>();
            CreateMap<user_account, UserAccountDTO>();

            CreateMap<ProductParentDTO, product_parent>();
            CreateMap<product_parent, ProductParentDTO>();

            CreateMap<ProductObjectDTO, product_object>();
            CreateMap<product_object, ProductObjectDTO>();

            CreateMap<product, ProductColorsDTO>();
            CreateMap<ProductColorsDTO, product>();

            CreateMap<product_icon, ProductIconsDTO>();
            CreateMap<ProductIconsDTO, product_icon>();

            CreateMap<product_size, ProductSizeDTO>();
            CreateMap<ProductSizeDTO, product_size>();

            CreateMap<ProductImgDTO, product_img>();
            CreateMap<product_img, ProductImgDTO>();

            CreateMap<category, ProductCategoriesDTO>();
            CreateMap<ProductCategoriesDTO, category>();

            CreateMap<SubCategoryDTO, sub_category>();
            CreateMap<sub_category, SubCategoryDTO>();

            CreateMap<supplier, SupplierDTO>();
            CreateMap<SupplierDTO, supplier>();


            CreateMap<GoodsReceiptDTO, goods_receipt>();
            CreateMap<goods_receipt, GoodsReceiptDTO>();

            CreateMap<goods_receipt_detail, GoodReceiptDetailsDTO>();
            CreateMap<GoodReceiptDetailsDTO, goods_receipt_detail>();

            CreateMap<size, SizeDTO>();
            CreateMap<SizeDTO, size>();

            CreateMap<SupplierDTO, supplier>();
            CreateMap<supplier, SupplierDTO>();

            CreateMap<GetTheSizeProductResult, SizeDTO>();


            CreateMap<SizeDTO, GetTheSizeProductCurrentResult>()
         .ForMember(dest => dest.size_id, opt => opt.MapFrom(src => src.size_id))
         .ForMember(dest => dest.size_name, opt => opt.MapFrom(src => src.size_name));

            CreateMap<GetTheSizeProductCurrentResult, SizeDTO>()
                .ForMember(dest => dest.size_id, otp => otp.MapFrom(src => src.size_id))
              .ForMember(dest => dest.size_name, opt => opt.MapFrom(src => src.size_name));
        }
    }
}
