using LibDTO;
using MappingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using LibConstants;
namespace LibDAL
{
    public class ProductColorRepository
    {
        private readonly DbContextDataContext _db;

        public ProductColorRepository(DbContextDataContext db)
        {
            _db = db;
        }

        public int Add(ProductColorsDTO entity)
        {
            try
            {
                var tempEntity = AutoMapperConfig.Mapper.Map<ProductColorsDTO, product>(entity);
                _db.products.InsertOnSubmit(tempEntity);
                _db.SubmitChanges();
                return 1;

            }
            catch (Exception e)
            {
                throw e;
           //     return 0;
            }
        }

        public int Delete(int id)
        {
            try
            {
                var existEntity = _db.products.Where(t => t.product_id == id).FirstOrDefault();
                if (existEntity != null)
                {
                    _db.products.DeleteOnSubmit(existEntity);
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

        public IEnumerable<ProductColorsDTO> GetAll()
        {
            var list = _db.products.Select(t => AutoMapperConfig.Mapper.Map<product, ProductColorsDTO>(t)).ToList();
            return list;
        }
        public ProductColorsDTO GetLast()
        {
            var lastProduct = _db.products.ToList().LastOrDefault();
            if (lastProduct == null)
                return null;

            var mappedProduct = AutoMapperConfig.Mapper.Map<product, ProductColorsDTO>(lastProduct);
            return mappedProduct;
        }

        public ProductColorsDTO GetByID(int id)
        {
            var productDTO = _db.products.Where(t => t.product_id == id).FirstOrDefault();
            if (productDTO != null)
            {
                return AutoMapperConfig.Mapper.Map<product, ProductColorsDTO>(productDTO);
            }
            return null;
        }

        public ProductParentDTO BelongsTo()
        {
            throw new NotImplementedException();
        }

        public int DeleteProductSize(int product_size_id)
        {
            try
            {
                var existEntity = _db.product_sizes.Where(t => t.product_size_id == product_size_id).FirstOrDefault();
                if (existEntity != null)
                {
                    _db.product_sizes.DeleteOnSubmit(existEntity);
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

        public TypeSize GetTypeSize(int id)
        {
            var product = _db.product_parents.Where(t => t.product_parent_id == id).FirstOrDefault();
            var subCategory = _db.sub_categories.Where(t => t.sub_categories_id == product.sub_categories_id).FirstOrDefault();
            var Category = _db.categories.Where(t => t.categories_id == subCategory.categories_id).FirstOrDefault();
            if (Category.categories_name == "Shoes")
            {
                return TypeSize.Shoes;
            }
            else
            {
                return TypeSize.Clothing;
            }
        }

        public int GetQuantity(int product_size_id)
        {
            product_size temp = _db.product_sizes.Where(t => t.product_size_id == product_size_id).FirstOrDefault();
            return (int)temp.soluong;
        }

        public List<SupplierDTO> GetSuppliers(int suppler_id)
        {
            var list = _db.suppliers.Where(t => t.supplier_id == suppler_id).Select(t => AutoMapperConfig.Mapper.Map<supplier, SupplierDTO>(t)).ToList();
            if (list != null)
            {
                return list;
            }
            return null;
        }

        public int Update(ProductColorsDTO entity)
        {
            try
            {
                var existEntity = _db.products.Where(t => t.product_id == entity.product_id).FirstOrDefault();
                if (existEntity != null)
                {
                    existEntity.product_more_info = entity.product_more_info;
                    existEntity.product_img = entity.product_img;
                    existEntity.product_size_and_fit = entity.product_size_and_fit;
                    existEntity.product_style_code = entity.product_style_code;
                    existEntity.product_color_shown = entity.product_color_shown;
                    existEntity.product_description = entity.product_description;
                    existEntity.product_description2 = entity.product_description2;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<GetTheSizeProductCurrentResult> GetProductSize(int product_id)
        {
            var list = _db.GetTheSizeProductCurrent(product_id).ToList();
            return list;
        }

        public List<ProductImgDTO> GetImages(int product_id)
        {
            var list = _db.product_imgs.Where(t => t.product_id == product_id).ToList().Select(temp => AutoMapperConfig.Mapper.Map<product_img, ProductImgDTO>(temp)).ToList();
            return list;
        }
    }
}
