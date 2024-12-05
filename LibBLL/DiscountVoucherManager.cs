using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDAL;
using LibDTO;

namespace LibBLL
{
    public class DiscountVoucherManager
    {
        private readonly DiscountVoucherResponsitory _discountVoucherResponsitory;

        public DiscountVoucherManager(DiscountVoucherResponsitory discountVoucherResponsitory)
        {
            _discountVoucherResponsitory = discountVoucherResponsitory;
        }

        public DiscountVoucherManager()
        {
            _discountVoucherResponsitory = new DiscountVoucherResponsitory(new DbContextDataContext());
        }

        public List<DiscountVoucherDTO> GetAll()
        {
            return _discountVoucherResponsitory.getDiscountVoucher();
        }

        public int Add(DiscountVoucherDTO discountVoucher)
        {
            return _discountVoucherResponsitory.AddDiscountVoucher(discountVoucher);
        }

        public int AddQuantity(DiscountVoucherDTO discountVoucher)
        {
            return _discountVoucherResponsitory.AddDiscountVoucherQuantity(discountVoucher);
        }

        public int Update(DiscountVoucherDTO discountVoucher)
        {
            return _discountVoucherResponsitory.Edit(discountVoucher);
        }

        public int Delete(int id)
        {
            return _discountVoucherResponsitory.Delete(id);
        }

        public int GetDiscountVoucherQuantity(int discountVoucherId)
        {
            return _discountVoucherResponsitory.getDiscountVoucherQuantity(discountVoucherId);
        }
    }
}
