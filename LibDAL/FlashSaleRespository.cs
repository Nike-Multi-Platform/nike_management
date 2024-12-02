using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDTO;
using MappingLayer;

namespace LibDAL
{
    internal class FlashSaleRespository
    {
        DbContextDataContext _db = new DbContextDataContext();

        public FlashSaleRespository()
        {
            _db = new DbContextDataContext();
        }

        public FlashSaleRespository(DbContextDataContext db)
        {
            _db = db;
        }

        public List<FlashSaleDTO> getFlashSale()
        {
            return _db.flash_sales
                        .Select(t => AutoMapperConfig.Mapper.Map<flash_sale, FlashSaleDTO>(t))
                        .ToList();
        }
        public int AddFlashSale(FlashSaleDTO flashSale)
        {
            try
            {
                var entity = AutoMapperConfig.Mapper.Map<FlashSaleDTO, flash_sale>(flashSale);
                _db.flash_sales.InsertOnSubmit(entity);
                _db.SubmitChanges();
                return 1;

            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Edit(FlashSaleDTO flashSale)
        {
            try
            {
                var entity = _db.flash_sales.FirstOrDefault(t => t.flash_sale_id == flashSale.flash_sale_id);
                if (entity != null)
                {
                    entity.flash_sale_name = flashSale.flash_sale_name;
                    entity.ended_at = flashSale.end_date;
                    entity.flash_sale_discount = flashSale.flash_sale_discount;
                    entity.flash_sale_description = flashSale.flash_sale_description;
                    entity.flash_sale_status = flashSale.flash_sale_status;
                    _db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        /*        public List<UserOrderDTO> GetUserOrders()
                {
                    return _db.user_orders
                               .Select(emp => AutoMapperConfig.Mapper.Map<user_order, UserOrderDTO>(emp))
                               .ToList()
                               .Select(userOrderDto =>
                               {
                                   var userOrderStatus = _db.user_order_status.FirstOrDefault(status => status.user_order_status_id == userOrderDto.User_order_status_id);
                                   userOrderDto.UserOrderStatusDTO = AutoMapperConfig.Mapper.Map<user_order_status, UserOrderStatusDTO>(userOrderStatus);
                                   return userOrderDto;
                               })
                               .ToList();
                }*/
    }
}
