using LibDAL;
using LibDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBLL
{
    public class UserOrderStatusManager
    {
        UserOrderStatusRepository userOrderStatusRepository = new UserOrderStatusRepository();
        public UserOrderStatusManager(UserOrderStatusRepository userOrderStatusRepository)
        {
            this.userOrderStatusRepository = userOrderStatusRepository;
        }

        public UserOrderStatusManager()
        {
            userOrderStatusRepository = new UserOrderStatusRepository();
        }

        public List<UserOrderStatusDTO> GetUserOrderStatus()
        {
            return userOrderStatusRepository.GetUserOrderStatus();
        }
    }
}
