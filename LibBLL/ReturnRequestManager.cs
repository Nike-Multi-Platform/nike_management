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
    }
}
