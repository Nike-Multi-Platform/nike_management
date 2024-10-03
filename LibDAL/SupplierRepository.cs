using LibDTO;
using MappingLayer;
using System.Collections.Generic;
using System.Linq;
namespace LibDAL
{
    public class SupplierRepository
    {
        DbContextDataContext _db;
        public SupplierRepository(DbContextDataContext db)
        {
            _db = db;
        }

        public IEnumerable<SupplierDTO> GetAll()
        {
            var list = _db.suppliers.Select(t => AutoMapperConfig.Mapper.Map<supplier, SupplierDTO>(t)).ToList();
            return list;
        }
    }
}
