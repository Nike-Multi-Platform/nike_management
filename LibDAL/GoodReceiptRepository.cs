using LibDTO;
using MappingLayer;
using System.Linq;
namespace LibDAL
{
    public class GoodReceiptRepository
    {
        DbContextDataContext _db;
        public GoodReceiptRepository(DbContextDataContext db)
        {
            _db = db;
        }



        public GoodsReceiptDTO CreateReceipt(GoodsReceiptDTO goodsReceiptDTO)
        {
            goods_receipt goods_Receipt = AutoMapperConfig.Mapper.Map<GoodsReceiptDTO, goods_receipt>(goodsReceiptDTO);
            _db.goods_receipts.InsertOnSubmit(goods_Receipt);
            _db.SubmitChanges();
            goods_Receipt = _db.goods_receipts.Last();
            return AutoMapperConfig.Mapper.Map<goods_receipt, GoodsReceiptDTO>(goods_Receipt);
        }

        public int Update(GoodsReceiptDTO goodsReceiptDTO)
        {

            return 1;
        }

    }
}
