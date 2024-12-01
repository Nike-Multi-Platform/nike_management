using LibDTO;
using MappingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LibDAL
{
    public class UserOrderStatusRepository
    {
        private readonly DbContextDataContext _db;
        public UserOrderStatusRepository(DbContextDataContext db)
        {
            _db = db;            
        }

        public UserOrderStatusRepository()
        {
            _db = new DbContextDataContext();
        }

        public List<UserOrderStatusDTO> GetUserOrderStatus()
        {
            return _db.user_order_status
                       .Select(emp => AutoMapperConfig.Mapper.Map<user_order_status, UserOrderStatusDTO>(emp))
                       .ToList();
        }


    }
}
