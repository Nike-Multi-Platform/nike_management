using LibDAL;
using LibDTO;
using System;
using System.Collections.Generic;
using LibConstants;
namespace LibBLL
{
   public class ProductColorManager : IRepository<ProductColorsDTO>
    {
        public ProductColorRepository _productColorRepository;
        public ProductColorManager(ProductColorRepository productColorRepository)
        {
            _productColorRepository = productColorRepository;
        }
        public ProductColorManager()
        {
            _productColorRepository = new ProductColorRepository(new DbContextDataContext());
        }
        public int Add(ProductColorsDTO entity)
        {
            return _productColorRepository.Add(entity);
        }

        public ProductColorsDTO GetLast()
        {
            return _productColorRepository.GetLast();
        }
        public int Delete(int id)
        {
            return _productColorRepository.Delete(id);
        }

        public IEnumerable<ProductColorsDTO> GetAll()
        {
            return _productColorRepository.GetAll();
        }

        public ProductColorsDTO GetByID(int id)
        {
            return _productColorRepository.GetByID(id);
        }

        public string Name()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductColorsDTO> Search(string search)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductColorsDTO enity)
        {
            return _productColorRepository.Update(enity);
        }

        public ProductParentDTO BelongsTo()
        {
            return _productColorRepository.BelongsTo();
        }

        public List<GetTheSizeProductCurrentResult> GetProductSizesByID(int product_id)
        {
            return _productColorRepository.GetProductSize(product_id);
        }
        public int DeleteProductSize(int product_size_id)
        {
            return _productColorRepository.DeleteProductSize(product_size_id);
        }
        public List<SupplierDTO> GetSuppliers(int suppler_id)
        {
            return _productColorRepository.GetSuppliers(suppler_id);
        }
        public int GetQuantity(int product_size_id)
        {
            return _productColorRepository.GetQuantity(product_size_id);
        }
        public TypeSize GetTypeSize(int id)
        {
            return _productColorRepository.GetTypeSize(id);
        }
       
    }
}
