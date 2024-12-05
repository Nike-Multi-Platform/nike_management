using LibDAL;
using LibDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBLL
{
    public class ReturnRequestManager
    {
        readonly ReturnRequestRepositoty _returnRequestRepositoty;
        public ReturnRequestManager()
        {
            _returnRequestRepositoty = new ReturnRequestRepositoty();
        }

        public ReturnRequestManager(ReturnRequestRepositoty returnRequestRepositoty)
        {
            _returnRequestRepositoty = returnRequestRepositoty;
        }

        public List<ReturnRequestDTO> GetReturnRequest(int request_type_id)
        {
            return _returnRequestRepositoty.GetReturnRequest(request_type_id);
        }

        public List<ReturnRequestTypeDTO> GetReturnRequestTypes()
        {
            return _returnRequestRepositoty.GetReturnRequestTypes();
        }

        public UserOrderDTO AcceptReturn(int return_request_id, int user_order_id, string order_code, int order_status)
        {
            return _returnRequestRepositoty.AcceptReturn(return_request_id, user_order_id, order_code, order_status);
        }

        public UserOrderDTO UpdateReturnOrderCode(int user_order_id, string order_code)
        {
            return _returnRequestRepositoty.UpdateReturnOrderCode(user_order_id, order_code);
        }

        public List<ReturnRequestImgDTO> GetReturnRequestImgs(int return_request_id)
        {
            return _returnRequestRepositoty.GetReturnRequestImgs(return_request_id);
        }

        public ReturnRequestDTO RejectRequest(int return_request_id)
        {
            return _returnRequestRepositoty.RejectRequest(return_request_id);
        }

    }
}
