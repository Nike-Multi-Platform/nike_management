using LibDAL;
using LibDTO;
using System;
using System.Collections.Generic;

namespace LibBLL
{
    public class SizeManager : IRepository<SizeDTO>
    {
        SizeRepository _sizeRepository = new SizeRepository(new DbContextDataContext());
        public SizeManager()
        {

        }

        public int Add(SizeDTO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SizeDTO> GetAll()
        {
            return _sizeRepository.GetAll();
        }

        public SizeDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public string Name()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SizeDTO> Search(string search)
        {
            throw new NotImplementedException();
        }

        public int Update(SizeDTO enity)
        {
            throw new NotImplementedException();
        }
    }
}
