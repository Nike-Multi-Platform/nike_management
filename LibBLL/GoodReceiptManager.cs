using LibDAL;
using LibDTO;
namespace LibBLL
{
    public class GoodReceiptManager
    {
        GoodReceiptRepository _goodReceiptRepository;
        public GoodReceiptManager(GoodReceiptRepository goodReceiptRepository)
        {
            _goodReceiptRepository = goodReceiptRepository;
        }
        public GoodsReceiptDTO CreateReceipt(GoodsReceiptDTO goodsReceiptDTO)
        {
            return _goodReceiptRepository.CreateReceipt(goodsReceiptDTO);
        }
        public int Update(GoodsReceiptDTO goodsReceiptDTO)
        {
            return _goodReceiptRepository.Update(goodsReceiptDTO);
        }

    }
}
