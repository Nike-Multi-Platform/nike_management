using LibDTO;
using MappingLayer;
using System.Collections.Generic;
using System.Linq;
namespace LibDAL
{
    public class SizeRepository
    {
        private DbContextDataContext _db;
        public SizeRepository(DbContextDataContext db)
        {
            _db = db;
        }

        public IEnumerable<SizeDTO> GetAll()
        {
            var list = _db.sizes.Select(t => AutoMapperConfig.Mapper.Map<size, SizeDTO>(t)).ToList();
            return list;
        }

    }
}
