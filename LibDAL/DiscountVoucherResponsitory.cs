using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDTO;
using AutoMapper;

namespace LibDAL
{
    public class DiscountVoucherResponsitory
    {
        DbContextDataContext _db = new DbContextDataContext();

        public DiscountVoucherResponsitory()
        {
            _db = new DbContextDataContext();
        }

        public DiscountVoucherResponsitory(DbContextDataContext db)
        {
            _db = db;
        }

        public List<DiscountVoucherDTO> getDiscountVoucher()
        {
            return _db.discount_vouchers
              .OrderByDescending(t => t.started_at)
              .Select(t => new DiscountVoucherDTO
              {
                  discount_voucher_id = t.discount_voucher_id,
                  voucer_name = t.voucher_name,
                  voucher_code = t.voucher_code,
                  discount_type = t.discount_type,
                  usage = t.usage,
                  quantity = t.quantity,
                  min_order_value = t.min_order_value,
                  discount_value = t.discount_value,
                  discount_max_value = t.discount_max_value,
                  discription = t.description,
                  Start_at = t.started_at,
                  End_at = t.ended_at
              })
              .ToList();
        }

        public int AddDiscountVoucher(DiscountVoucherDTO discountVoucher)
        {
            // Validate the discount voucher


            try
            {
                // Check if the voucher code already exists
                if (checkExistedVoucher(discountVoucher) == 3)
                {
                    Console.WriteLine($"Duplicate voucher code: {discountVoucher.voucher_code}");
                    return 3; // Voucher code already exists
                }

                // Insert the new discount voucher
                _db.discount_vouchers.InsertOnSubmit(new discount_voucher
                {
                    voucher_name = discountVoucher.voucer_name,
                    voucher_code = discountVoucher.voucher_code,
                    discount_type = discountVoucher.discount_type,
                    usage = discountVoucher.usage,
                    quantity = 100, // Adjust this based on your needs
                    min_order_value = discountVoucher.min_order_value,
                    discount_value = discountVoucher.discount_value,
                    discount_max_value = discountVoucher.discount_max_value,
                    description = discountVoucher.discription,
                    started_at = discountVoucher.Start_at,
                    ended_at = discountVoucher.End_at
                });

                _db.SubmitChanges();
                Console.WriteLine($"Voucher added successfully: {discountVoucher.voucher_code}");
                return 1; // Success
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddDiscountVoucher: {ex.Message}");
                return 0; // Error
            }
        }


        public int AddDiscountVoucherQuantity(DiscountVoucherDTO discountVoucher)
        {
            try
            {
                var entity = _db.discount_vouchers.FirstOrDefault(t => t.discount_voucher_id == discountVoucher.discount_voucher_id);
                if (entity != null)
                {
                    entity.quantity += discountVoucher.quantity;
                    _db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddDiscountVoucherQuantity: {ex.Message}");
                return 0;
            }
        }
        public int Edit(DiscountVoucherDTO discountVoucher)
        {
            try
            {
                // Lấy dữ liệu voucher từ cơ sở dữ liệu
                var entity = _db.discount_vouchers.FirstOrDefault(t => t.discount_voucher_id == discountVoucher.discount_voucher_id);

                // Kiểm tra xem voucher có tồn tại không
                if (entity == null)
                {
                    Console.WriteLine("Không tìm thấy voucher.");
                    return 0; // Trả về 0 để chỉ không tìm thấy
                }

                entity.voucher_name = discountVoucher.voucer_name;
                entity.voucher_code = discountVoucher.voucher_code;
                entity.discount_type = discountVoucher.discount_type;
                entity.usage = discountVoucher.usage;
                entity.min_order_value = discountVoucher.min_order_value;
                entity.discount_value = discountVoucher.discount_value;
                entity.discount_max_value = discountVoucher.discount_max_value;
                entity.description = discountVoucher.discription;
                entity.started_at = discountVoucher.Start_at;
                entity.ended_at = discountVoucher.End_at;

                // Lưu thay đổi
                _db.SubmitChanges();
                Console.WriteLine("Cập nhật voucher thành công.");
                return 1; // Trả về 1 để chỉ thành công
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi khi chỉnh sửa: {ex.Message}");
                return 0; // Trả về 0 để chỉ lỗi chung
            }
        }


        public int Delete(int id)
        {
            try
            {
                var entity = _db.discount_vouchers.FirstOrDefault(t => t.discount_voucher_id == id);
                if (entity != null)
                {
                    _db.discount_vouchers.DeleteOnSubmit(entity);
                    _db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Delete: {ex.Message}");
                return 0;
            }

        }

        public int checkExistedVoucher(DiscountVoucherDTO discountVoucher)
        {
            if (_db.discount_vouchers.Any(v => v.voucher_code == discountVoucher.voucher_code))
            {
                return 3;
            }
            return 0;
        }

        public int getDiscountVoucherQuantity(int discountVoucherId)
        {
            return _db.discount_vouchers.FirstOrDefault(v => v.discount_voucher_id == discountVoucherId).quantity;
        }

    }
}
