using LibDTO;
using MappingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibDAL
{
    public class UserOrdersRepository
    {
        private readonly DbContextDataContext _db;
        public UserOrdersRepository(DbContextDataContext db)
        {
            _db = db;
        }

        public UserOrdersRepository()
        {
            _db = new DbContextDataContext();
        }

        public List<UserOrderDTO> GetUserOrders()
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
        }

        public List<ProductParentDTO> getProductParentByUserOrder(int user_order_id)
        {
            var productParents = _db.user_order_products
                .Where(userOrderProduct => userOrderProduct.user_order_id == user_order_id)

                .Where(userOrderProduct => userOrderProduct.product_size != null
                                           && userOrderProduct.product_size.product != null
                                           && userOrderProduct.product_size.product.product_parent != null)

                .Select(userOrderProduct => userOrderProduct.product_size.product.product_parent)

                .Distinct()

                .Select(productParent => AutoMapperConfig.Mapper.Map<product_parent, ProductParentDTO>(productParent))

                .ToList();

            return productParents;
        }

        public List<UserOrderDTO> GetUserOrderByStatus(int user_order_status_id)
        {
            return _db.user_orders
                       .Where(emp => emp.user_order_status_id == user_order_status_id)
                       .Select(emp => AutoMapperConfig.Mapper.Map<user_order, UserOrderDTO>(emp))
                       .ToList()
                       .Select(userOrderDto =>
                       {
                           var userOrderStatus = _db.user_order_status.FirstOrDefault(status => status.user_order_status_id == userOrderDto.User_order_status_id);
                           userOrderDto.UserOrderStatusDTO = AutoMapperConfig.Mapper.Map<user_order_status, UserOrderStatusDTO>(userOrderStatus);
                           return userOrderDto;
                       })
                       .ToList();
            }
        }

}
