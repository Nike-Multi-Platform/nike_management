using LibDAL;
using LibDTO;
using System;
using System.Collections.Generic;

namespace LibBLL
{
   public class SupplierManager : IRepository<SupplierDTO>
    {
        SupplierRepository _supplierRepository = new SupplierRepository(new DbContextDataContext());
        public SupplierManager()
        {

        }
        public int Add(SupplierDTO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SupplierDTO> GetAll()
        {
            return _supplierRepository.GetAll();
        }

        public SupplierDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public string Name()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SupplierDTO> Search(string search)
        {
            throw new NotImplementedException();
        }

        public int Update(SupplierDTO enity)
        {
            throw new NotImplementedException();
        }
    }
}
