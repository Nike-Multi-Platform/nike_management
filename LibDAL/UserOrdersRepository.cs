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

        public UserOrderDTO GetUserOrderByID(int user_order_id)
        {
            var userOrder = _db.user_orders.FirstOrDefault(order => order.user_order_id == user_order_id);
            var userOrderDTO = AutoMapperConfig.Mapper.Map<user_order, UserOrderDTO>(userOrder);

            var userOrderStatus = _db.user_order_status.FirstOrDefault(status => status.user_order_status_id == userOrderDTO.User_order_status_id);
            userOrderDTO.UserOrderStatusDTO = AutoMapperConfig.Mapper.Map<user_order_status, UserOrderStatusDTO>(userOrderStatus);
            return userOrderDTO;
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

        public List<ProductParentDTO> getProductParentBySize(int product_size_id)
        {
            var productParents = _db.user_order_products
                .Where(userOrderProduct => userOrderProduct.product_size_id == product_size_id)
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

        public UserOrderDTO UpdateOrderCode(int user_order_id, string order_code)
        {
            var userOrder = _db.user_orders.FirstOrDefault(order => order.user_order_id == user_order_id);
            userOrder.order_code = order_code;
            userOrder.user_order_status_id = 2;
            _db.SubmitChanges();
            return AutoMapperConfig.Mapper.Map<user_order, UserOrderDTO>(userOrder);
        }

        public UserOrderDTO UpdateOrderStatus(int user_order_id, int user_order_status_id, string status)
        {
            // get user order
            UserOrderDTO userOrderDTO = GetUserOrderByID(user_order_id);

            if (status == "ready_to_pick" && user_order_status_id != 2 && user_order_status_id != 6)
            {
                var userOrder = _db.user_orders.FirstOrDefault(order => order.user_order_id == user_order_id);
                userOrder.user_order_status_id = 2;
                _db.SubmitChanges();
                return AutoMapperConfig.Mapper.Map<user_order, UserOrderDTO>(userOrder);
            }
            else if(status == "picked" && user_order_status_id != 3 && user_order_status_id != 6)
            {
                var userOrder = _db.user_orders.FirstOrDefault(order => order.user_order_id == user_order_id);
                userOrder.user_order_status_id = 3;
                _db.SubmitChanges();
                return AutoMapperConfig.Mapper.Map<user_order, UserOrderDTO>(userOrder);
            }
            else if(status == "cancel" && user_order_status_id != 5 && user_order_status_id != 6)
            {
                var userOrder = _db.user_orders.FirstOrDefault(order => order.user_order_id == user_order_id);
                userOrder.user_order_status_id = 6;
                _db.SubmitChanges();
                return AutoMapperConfig.Mapper.Map<user_order, UserOrderDTO>(userOrder);
            }
            else if(status == "delivered" && userOrderDTO.Return_expiration_date == null)
            {
                userOrderDTO.Return_expiration_date = DateTime.Now.AddDays(7);
                var userOrder = _db.user_orders.FirstOrDefault(order => order.user_order_id == user_order_id);
                userOrder.return_expiration_date = userOrderDTO.Return_expiration_date;
                userOrder.user_order_status_id = 4;
                _db.SubmitChanges();
                return AutoMapperConfig.Mapper.Map<user_order, UserOrderDTO>(userOrder);
            }
            return null;
        }

        public List<UserOrderProductDTO> GetProductOrder(int user_order_id)
        {
            return _db.user_order_products
                       .Where(emp => emp.user_order_id == user_order_id)
                       .Select(emp => AutoMapperConfig.Mapper.Map<user_order_product, UserOrderProductDTO>(emp))
                       .ToList();
        }

        public UserOrderDTO CancelOrder(int user_order_id)
        { 
            var userOrder = _db.user_orders.FirstOrDefault(order => order.user_order_id == user_order_id);
            userOrder.user_order_status_id = 5;
            userOrder.is_canceled_by = 2;
            _db.SubmitChanges();
            return AutoMapperConfig.Mapper.Map<user_order, UserOrderDTO>(userOrder);
        }

    }

}
