using LibDTO;
using MappingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDAL
{
    public class ReturnRequestRepositoty
    {
        private readonly DbContextDataContext _db;
        public ReturnRequestRepositoty(DbContextDataContext db)
        {
            _db = db;
        }

        public ReturnRequestRepositoty()
        {
            _db = new DbContextDataContext();
        }

        public List<ReturnRequestDTO> GetReturnRequest(int request_type_id)
        {
            return _db.return_requests
                      .Where(r => r.request_type_id == request_type_id)
                      .Select(emp => AutoMapperConfig.Mapper.Map<return_request, ReturnRequestDTO>(emp))
                      .ToList();
        }

        public List<ReturnRequestTypeDTO> GetReturnRequestTypes()
        {
            return _db.request_types
                      .Select(emp => AutoMapperConfig.Mapper.Map<request_type, ReturnRequestTypeDTO>(emp))
                        .ToList();
        }

        public UserOrderDTO AcceptReturn(int user_order_id, string order_code)
        {
            var userOrder = _db.user_orders.FirstOrDefault(order => order.user_order_id == user_order_id);
        
            userOrder.order_code_return = order_code;
            userOrder.user_order_status_id = 6;
            userOrder.is_canceled_by = 1;
            _db.SubmitChanges();
            return AutoMapperConfig.Mapper.Map<user_order, UserOrderDTO>(userOrder);
        }
    }
}
