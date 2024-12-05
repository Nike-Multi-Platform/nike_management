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


            CreateMap<user_order, UserOrderDTO>();
            CreateMap<UserOrderDTO, user_order>();

            CreateMap<user_order_status, UserOrderStatusDTO>();
            CreateMap<UserOrderStatusDTO, user_order_status>();

            CreateMap<flash_sale, FlashSaleDTO>();
            CreateMap<FlashSaleDTO, flash_sale>();

            CreateMap<flash_sale_time_frame, FlashSaleTimeFrameDTO>();
            CreateMap<FlashSaleTimeFrameDTO, flash_sale_time_frame>();

            CreateMap<user_wallet, UserWalletDTO>();
            CreateMap<UserWalletDTO, user_wallet>();

            CreateMap<return_request, ReturnRequestDTO>();
            CreateMap<ReturnRequestDTO, return_request>();

            CreateMap<return_request_img, return_request_img>();
            CreateMap<return_request_img, ReturnRequestImgDTO>();

            CreateMap<request_type,ReturnRequestTypeDTO>();
            CreateMap<ReturnRequestTypeDTO, request_type>();


            CreateMap<SizeDTO, GetTheSizeProductCurrentResult>()
         .ForMember(dest => dest.size_id, opt => opt.MapFrom(src => src.size_id))
         .ForMember(dest => dest.size_name, opt => opt.MapFrom(src => src.size_name));

            CreateMap<GetTheSizeProductCurrentResult, SizeDTO>()
                .ForMember(dest => dest.size_id, otp => otp.MapFrom(src => src.size_id))
              .ForMember(dest => dest.size_name, opt => opt.MapFrom(src => src.size_name));



            CreateMap<UserOrderProductDTO, ProductSizeDTO>()
         .ForMember(dest => dest.product_size_id, opt => opt.MapFrom(src => src.product_size_id));

            CreateMap<ProductSizeDTO, UserOrderProductDTO>()
                .ForMember(dest => dest.product_size_id, opt => opt.MapFrom(src => src.product_size_id));

            CreateMap<user_order_product, UserOrderProductDTO>()
            .ForMember(dest => dest.user_order_id, opt => opt.MapFrom(src => src.user_order_id))
            .ForMember(dest => dest.product_size_id, opt => opt.MapFrom(src => src.product_size_id))
            .ForMember(dest => dest.amount, opt => opt.MapFrom(src => src.amount));
        }
    }
}
