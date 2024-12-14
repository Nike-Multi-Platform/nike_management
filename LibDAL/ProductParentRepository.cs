using LibDTO;
using MappingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
namespace LibDAL
{
    public class ProductParentRepository
    {
        private readonly DbContextDataContext _db;

        public ProductParentRepository(DbContextDataContext db)
        {
            _db = db;
        }
        public List<ProductParentDTO> getProductParents()
        {
            List<ProductParentDTO> l = _db.product_parents.Select(emp => AutoMapperConfig.Mapper.Map<product_parent, ProductParentDTO>(emp)).ToList();
            if (l != null)
            {
                return l;
            }

            return null;
        }

        public List<ProductColorsDTO> getProductColor(int product_parent_id)
        {
            List<product> products = _db.products.Where(emp => (int)emp.product_parent_id == product_parent_id).ToList();
            List<ProductColorsDTO> l = new List<ProductColorsDTO>();
            foreach (product p in products)
            {
                l.Add(AutoMapperConfig.Mapper.Map<product, ProductColorsDTO>(p));
            }
            if (l != null)
            {
                return l;
            }
            return null;
        }

        public List<ProductParentDTO> getProductParentsBySubCategory(int id)
        {
            var list = _db.product_parents.Where(emp => emp.sub_categories_id == id).Select(t => AutoMapperConfig.Mapper.Map<product_parent, ProductParentDTO>(t)).ToList();

            if (list != null)
            {
                return list;
            }
            return null;
        }

        public int Save(ProductParentDTO productParent)
        {
            try
            {
                var item = AutoMapperConfig.Mapper.Map<ProductParentDTO, product_parent>(productParent);
                _db.product_parents.InsertOnSubmit(item);
                _db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public int Edit(ProductParentDTO productParent)
        {
            try
            {
                var existingProductParent = _db.product_parents.FirstOrDefault(p => p.product_parent_id == productParent.product_parent_id);
                if (existingProductParent != null)
                {
                    existingProductParent.product_parent_name = productParent.product_parent_name;
                    existingProductParent.thumbnail = productParent.thumbnail;
                    existingProductParent.weight = productParent.Weight;
                    existingProductParent.height = productParent.Height;
                    existingProductParent.length = productParent.Length;
                    existingProductParent.width = productParent.Width;
                    if (decimal.TryParse(productParent.product_price, out decimal price))
                    {
                        existingProductParent.product_price = price;
                    }
                    else
                    {
                        return 0;
                    }

                    existingProductParent.is_new_release = productParent.is_new_release;
                    existingProductParent.product_icons_id = productParent.product_icons_id;
                    _db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception e)
            {
                return 0;
            }
        }



        public List<ProductParentDTO> Search(string inputSearch)
        {
            try
            {
                bool isNumericSearch = int.TryParse(inputSearch, out int numericSearch);
                List<ProductParentDTO> result = _db.product_parents.Where(pd => pd.product_parent_name.Contains(inputSearch)
                || pd.product_parent_id == numericSearch || pd.product_price == numericSearch)
                    .ToList().Select(p => AutoMapperConfig.Mapper.Map<product_parent, ProductParentDTO>(p)).ToList();
                if (result != null)
                {
                    return result;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }



        public int Delete(int product_parent_id)
        {
            try
            {
                var existProductParents = _db.product_parents.Where(pd => pd.product_parent_id == product_parent_id).FirstOrDefault();
                _db.product_parents.DeleteOnSubmit(existProductParents);
                _db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public List<ProductObjectDTO> GetProductObjects()
        {
            List<ProductObjectDTO> l = _db.product_objects.Select(temp => AutoMapperConfig.Mapper.Map<product_object, ProductObjectDTO>(temp)).ToList();
            if (l != null)
            {
                return l;
            }
            return null;
        }

        public List<ProductIconsDTO> GetProductIcons()
        {
            List<ProductIconsDTO> l = _db.product_icons.Select(temp => AutoMapperConfig.Mapper.Map<product_icon, ProductIconsDTO>(temp)).ToList();
            if (l != null)
            {
                return l;
            }
            return null;
        }

    }
}
