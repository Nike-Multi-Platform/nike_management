using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDTO;
using MappingLayer;

namespace LibDAL
{
    public class FlashSaleRespository
    {
        DbContextDataContext _db = new DbContextDataContext();

        public FlashSaleRespository()
        {
            _db = new DbContextDataContext();
        }

        public FlashSaleRespository(DbContextDataContext db)
        {
            _db = db;
        }

        public List<FlashSaleDTO> getFlashSale()
        {
            return _db.flash_sales
              .OrderByDescending(t => t.createdAt)
              .Select(t => new FlashSaleDTO
              {
                  flash_sale_id = t.flash_sale_id,
                  flash_sale_name = t.flash_sale_name,
                  thumbnail = t.thumbnail,
                  status = t.status,
                  Start_at = t.started_at,
                  End_at = t.ended_at
              })
              .ToList();
        }
        public int AddFlashSale(FlashSaleDTO flashSale)
        {
            try
            {
                _db.flash_sales.InsertOnSubmit(new flash_sale
                {
                    flash_sale_name = flashSale.flash_sale_name,
                    started_at = flashSale.Start_at,
                    ended_at = flashSale.End_at,
                    thumbnail = flashSale.thumbnail,
                    status = flashSale.status,
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                });
                _db.SubmitChanges();
                return 1;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddFlashSale: {ex.Message}");
                return 0;
            }
        }

        public int Edit(FlashSaleDTO flashSale)
        {
            try
            {
                var entity = _db.flash_sales.FirstOrDefault(t => t.flash_sale_id == flashSale.flash_sale_id);
                if (entity != null)
                {
                    entity.flash_sale_name = flashSale.flash_sale_name;
                    entity.started_at = flashSale.Start_at;
                    entity.ended_at = flashSale.End_at;
                    entity.thumbnail = flashSale.thumbnail;
                    entity.status = flashSale.status;
                    entity.createdAt = DateTime.Now;
                    entity.updatedAt = DateTime.Now;
                    _db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Delete(FlashSaleDTO flashSale) {
            try
            {
                var entity = _db.flash_sales.FirstOrDefault(t => t.flash_sale_id == flashSale.flash_sale_id);
                if (entity != null)
                {
                    _db.flash_sales.DeleteOnSubmit(entity);
                    _db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

    }
}
