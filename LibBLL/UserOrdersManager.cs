using LibDAL;
using LibDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBLL
{
    public class UserOrdersManager
    {
        private readonly UserOrdersRepository _userOrdersRepository;
        public UserOrdersManager(UserOrdersRepository userOrdersRepository)
        {
            _userOrdersRepository = userOrdersRepository;
        }

        public UserOrdersManager()
        {
            _userOrdersRepository = new UserOrdersRepository(new DbContextDataContext());
        }
        public List<UserOrderDTO> GetUserOrders()
        {
            return _userOrdersRepository.GetUserOrders();
        }

        public UserOrderDTO GetUserOrderByID(int user_order_id)
        {
            return _userOrdersRepository.GetUserOrderByID(user_order_id);
        }
        public List<UserOrderDTO> GetUserOrderByStatus(int user_order_status_id)
        {
            return _userOrdersRepository.GetUserOrderByStatus(user_order_status_id);
        }

        public List<ProductParentDTO> getProductParentByUserOrder(int user_order_id)
        {
            return _userOrdersRepository.getProductParentByUserOrder(user_order_id);
        }

        public List<ProductParentDTO> getProductParentBySize(int product_size_id)
        {
            return _userOrdersRepository.getProductParentBySize(product_size_id);
        }
        public UserOrderDTO UpdateOrderCode(int user_order_id, string order_code)
        {
            return _userOrdersRepository.UpdateOrderCode(user_order_id, order_code);
        }

        public UserOrderDTO UpdateOrderStatus(int user_order_id, int user_order_status_id, string status)
        {
            return _userOrdersRepository.UpdateOrderStatus(user_order_id, user_order_status_id, status);
        }

        public List<UserOrderProductDTO> GetProductOrder(int user_order_id)
        {
            return _userOrdersRepository.GetProductOrder(user_order_id);
        }
    }
}
