using LibDAL;
using LibDTO;
using System;
using System.Collections.Generic;
namespace LibBLL
{
    public class ProductCategoriesManager : IRepository<ProductCategoriesDTO>
    {
        ProductCategoriesRepository _productCategoriesRepository;
        public ProductCategoriesManager(ProductCategoriesRepository productCategoriesRepository)
        {
            _productCategoriesRepository = productCategoriesRepository;
        }
        public ProductCategoriesManager()
        {
            _productCategoriesRepository = new ProductCategoriesRepository(new DbContextDataContext());
        }
        public IEnumerable<ProductCategoriesDTO> GetProductCategoriesByID(int id)
        {
            return _productCategoriesRepository.GetProductCategoriesByID(id);
        }
        public int Add(ProductCategoriesDTO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductCategoriesDTO> GetAll()
        {
            return _productCategoriesRepository.GetAll();
        }

        public ProductCategoriesDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public string Name()
        {
            return "Product Categoires";
        }

        public IEnumerable<ProductCategoriesDTO> Search(string search)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductCategoriesDTO enity)
        {
            throw new NotImplementedException();
        }
    }
}
