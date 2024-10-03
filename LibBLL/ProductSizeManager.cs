using LibDAL;
using LibDTO;
using System.Collections.Generic;
using LibConstants;
namespace LibBLL
{
   public class ProductSizeManager : IRepository<ProductSizeDTO>
    {
        private readonly ProductSizeRepository _productSizeRepository;

        public ProductSizeManager(ProductSizeRepository productSizeRepository)
        {
            _productSizeRepository = productSizeRepository;
        }
        public ProductSizeManager()
        {
            _productSizeRepository = new ProductSizeRepository(new DbContextDataContext());
        }
        /// <summary>
        /// id là id của thằng product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ProductSizeDTO> GetProductSizesByID(int id)
        {
            return _productSizeRepository.GetProductSizesByID(id);
        }

        public int Update(ProductSizeDTO productSizeDTO)
        {
            return _productSizeRepository.Update(productSizeDTO);
        }

        public int Add(ProductSizeDTO entity)
        {
            return _productSizeRepository.Add(entity);
        }
        /// <summary>
        /// truyền vào product_size_id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int product_size_id)
        {
            return _productSizeRepository.Delete(product_size_id);
        }

        public IEnumerable<ProductSizeDTO> Search(string search)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ProductSizeDTO> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ProductSizeDTO GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public string Name()
        {
            throw new System.NotImplementedException();
        }

        public List<SizeDTO> GetProductSizeInventory(int product_id,TypeSize typeSize)
        {
            return _productSizeRepository.GetProductSizeInventory(product_id, typeSize);
        }
        public List<SizeDTO> GetProductSizeCurrent(int product_id,TypeSize typeSize)
        {
            return _productSizeRepository.GetProductSizeCurrent(product_id, typeSize);
        }
    }
}
