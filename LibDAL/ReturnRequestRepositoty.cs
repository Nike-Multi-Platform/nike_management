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

        public UserOrderDTO AcceptReturn(int return_request_id ,int user_order_id, string order_code, int order_status)
        {
            var userOrder = _db.user_orders.FirstOrDefault(order => order.user_order_id == user_order_id);
            // refund
            if (userOrder.payment_method == "VNPAY")
            {
                // get user wallet 
                var user_wallet = _db.user_wallets.FirstOrDefault(wallet => wallet.user_id == userOrder.user_id);

                if (user_wallet == null)
                {
                    throw new Exception("User wallet not found");
                }
                // refund money to user wallet
                user_wallet.balance += ((long)userOrder.final_price - (long) userOrder.shipping_fee);
                user_wallet.updatedAt = DateTime.Now;

                var user_wallet_transaction = new user_wallet_transaction
                {
                    user_wallet_id = user_wallet.user_wallet_id,
                    amount = (long)userOrder.final_price - (long)userOrder.shipping_fee,
                    transaction_type = "refund",
                    transaction_date = DateTime.Now
                };

                _db.user_wallet_transactions.InsertOnSubmit(user_wallet_transaction);
            }

            // find product size and update quantity, return register flash sale product
            var userOrderProducts = _db.user_order_products.Where(product => product.user_order_id == user_order_id).ToList();
            foreach (var userOrderProduct in userOrderProducts)
            {
                var productSize = _db.product_sizes.FirstOrDefault(size => size.product_size_id == userOrderProduct.product_size_id);
                if (productSize == null)
                {
                    throw new Exception("Product size not found");
                }
                productSize.soluong += userOrderProduct.amount;

                var registerFlashSaleProduct = _db.register_flash_sale_products.FirstOrDefault(product => product.register_flash_sale_product1 == userOrderProduct.on_register_flash_sales_id);
                if (registerFlashSaleProduct != null)
                {
                    registerFlashSaleProduct.sold -= userOrderProduct.amount;
                }
            }

            // return discount voucher
            var discount_voucher = _db.discount_vouchers.FirstOrDefault(voucher => voucher.voucher_code == userOrder.vouchers_applied);
            if (discount_voucher != null)
            {
                discount_voucher.quantity += 1;
            }
            if(order_code != "")
            {
                userOrder.order_code_return = order_code;
            }
            userOrder.user_order_status_id = order_status;
            userOrder.is_canceled_by = 1;

            var returnRequest = _db.return_requests.FirstOrDefault(request => request.return_request_id == return_request_id);
            returnRequest.status_id = 1; // processed
            _db.SubmitChanges();
            return AutoMapperConfig.Mapper.Map<user_order, UserOrderDTO>(userOrder);
        }

        public ReturnRequestDTO RejectRequest(int return_request_id)
        {
            var returnRequest = _db.return_requests.FirstOrDefault(request => request.return_request_id == return_request_id);
            returnRequest.status_id = 2; // rejected
            _db.SubmitChanges();
            return AutoMapperConfig.Mapper.Map<return_request, ReturnRequestDTO>(returnRequest);
        }

        public UserOrderDTO UpdateReturnOrderCode(int user_order_id, string order_code)
        {
            var userOrder = _db.user_orders.FirstOrDefault(order => order.user_order_id == user_order_id);
            userOrder.order_code_return = order_code;
            _db.SubmitChanges();
            return AutoMapperConfig.Mapper.Map<user_order, UserOrderDTO>(userOrder);
        }

        public List<ReturnRequestImgDTO> GetReturnRequestImgs(int return_request_id) {
            return _db.return_request_imgs
                      .Where(img => img.return_request_id == return_request_id)
                      .Select(emp => AutoMapperConfig.Mapper.Map<return_request_img, ReturnRequestImgDTO>(emp))
                      .ToList();
        }
    }
}
