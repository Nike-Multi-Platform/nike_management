using LibDTO;
using MappingLayer;
using System.Collections.Generic;
using System.Linq;
namespace LibDAL
{
    public class ProductCategoriesRepository
    {
        private readonly DbContextDataContext _db;
        public ProductCategoriesRepository(DbContextDataContext db)
        {
            _db = db;
        }

        public IEnumerable<ProductCategoriesDTO> GetProductCategoriesByID(int id)
        {
            var list = _db.categories.Where(t => t.product_object_id == id).Select(t => AutoMapperConfig.Mapper.Map<category, ProductCategoriesDTO>(t)).ToList();
            if (list != null)
            {
                return list;
            }
            return null;
        }

        public IEnumerable<ProductCategoriesDTO> GetAll()
        {
            var list = _db.categories.Select(t => AutoMapperConfig.Mapper.Map<category, ProductCategoriesDTO>(t)).ToList();
            if (list != null)
            {
                return list;
            }
            return null;
        }
    }
}
