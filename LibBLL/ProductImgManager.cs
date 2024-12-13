using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDTO;
using LibDAL;
namespace LibBLL
{
    public class ProductImgManager
    {

        ProductImgRepository productImgRepository;
        public ProductImgManager()
        {
            productImgRepository = new ProductImgRepository(new DbContextDataContext());
        }
        public int Add(ProductImgDTO productImg)
        {
            return productImgRepository.Add(productImg);
        }
        public List<ProductImgDTO> getAll()
        {
            return productImgRepository.getAll();
        }

        public List<ProductImgDTO> getByID(int id)
        {
            return productImgRepository.getByIDRef(id);
        }
    }
}
