using LibDTO;
using MappingLayer;
using System.Collections.Generic;
using System.Linq;
namespace LibDAL
{
    public class SubcategoryRepository
    {
        DbContextDataContext _db;
        public SubcategoryRepository(DbContextDataContext db)
        {
            _db = db;
        }

        public IEnumerable<SubCategoryDTO> GetAllByID(int id)
        {
            var list = _db.sub_categories.Where(t => t.categories_id == id).Select(t => AutoMapperConfig.Mapper.Map<sub_category, SubCategoryDTO>(t)).ToList();
            if (list != null)
            {
                return list;
            }
            return null;
        }
    }
}
