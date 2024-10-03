using LibDTO;
using System.Collections.Generic;
using LibDAL;
namespace LibBLL
{
   public class GoodReceiptDetailsManager
    {
        GoodReceiptDetailsRepository _goodReceiptDetailsRepository;
        public GoodReceiptDetailsManager(GoodReceiptDetailsRepository goodReceiptDetailsRepository)
        {
            _goodReceiptDetailsRepository = goodReceiptDetailsRepository;
        }

        public int Add(List<GoodReceiptDetailsDTO> list)
        {
            return _goodReceiptDetailsRepository.Add(list);
        }
    }
}
