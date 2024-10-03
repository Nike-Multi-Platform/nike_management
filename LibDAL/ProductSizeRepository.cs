using LibConstants;
using LibDTO;
using MappingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
namespace LibDAL
{
    public class ProductSizeRepository
    {
        private readonly DbContextDataContext _db;
        //IRepository<T>
        public ProductSizeRepository(DbContextDataContext db)
        {
            _db = db;
        }

        public List<ProductSizeDTO> GetProductSizesByID(int id)
        {
            var list = _db.product_sizes.Where(t => t.product_id == id).ToList().Select(t => AutoMapperConfig.Mapper.Map<product_size, ProductSizeDTO>(t)).ToList();
            if (list != null)
            {
                return list;
            }
            return null;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productSize"></param>
        /// <returns>1 nếu thành công, 0 nếu thất bại</returns>
        public int Update(ProductSizeDTO productSize)
        {
            try
            {
                var existPz = _db.product_sizes.Where(p => p.product_size_id == productSize.product_size_id).FirstOrDefault();
                if (existPz != null)
                {
                    existPz.soluong = productSize.soluong;
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

        public int Delete(int product_size_id)
        {
            try
            {
                var exits = _db.product_sizes.Where(t => t.product_size_id == product_size_id).FirstOrDefault();
                if (exits != null)
                {
                    _db.product_sizes.DeleteOnSubmit(exits);
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

        public int Add(ProductSizeDTO entity)
        {
            try
            {
                var opEntity = AutoMapperConfig.Mapper.Map<ProductSizeDTO, product_size>(entity);
                _db.product_sizes.InsertOnSubmit(opEntity);
                _db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public List<SizeDTO> GetProductSizeInventory(int product_id, TypeSize typeSize)
        {
            var list = _db.GetTheSizeProduct(product_id, (int)typeSize).ToList().Select(t => AutoMapperConfig.Mapper.Map<GetTheSizeProductResult, SizeDTO>(t)).ToList();

            return list;
        }

        public List<SizeDTO> GetProductSizeCurrent(int product_id, TypeSize typeSize)
        {
            throw new NotImplementedException();
        }
    }
}
