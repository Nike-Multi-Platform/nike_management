using LibDTO;
using MappingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
namespace LibDAL
{
    public class ProductIconsRepository
    {
        DbContextDataContext _db;
        public ProductIconsRepository(DbContextDataContext db)
        {
            _db = db;
        }

        public int Add(ProductIconsDTO entity)
        {
            try
            {
                var item = AutoMapperConfig.Mapper.Map<ProductIconsDTO, product_icon>(entity);
                _db.product_icons.InsertOnSubmit(item);
                _db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public IEnumerable<ProductIconsDTO> GetAll()
        {
            var list = _db.product_icons.Select(t => AutoMapperConfig.Mapper.Map<product_icon, ProductIconsDTO>(t)).ToList();
            if (list != null)
            {
                return list;
            }
            return null;
        }
    }
}
