using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDTO;
using MappingLayer;
namespace LibDAL
{
    public class ProductImgRepository
    {
        private readonly DbContextDataContext _db;
        public ProductImgRepository(DbContextDataContext db)
        {
            _db = db;
        }

        public int Add(ProductImgDTO productImg)
        {
            try
            {

                _db.product_imgs.InsertOnSubmit(AutoMapperConfig.Mapper.Map<ProductImgDTO, product_img>(productImg));
                _db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public List<ProductImgDTO> getAll()
        {
            return _db.product_imgs.ToList().Select(t => AutoMapperConfig.Mapper.Map<product_img, ProductImgDTO>(t)).ToList();
        }
        public List<ProductImgDTO> getByIDRef(int id)
        {
            return _db.product_imgs.Where(t => t.product_id == id).Select(t => AutoMapperConfig.Mapper.Map<product_img, ProductImgDTO>(t)).ToList();

        }
        public int Update(ProductImgDTO img)
        {
            try
            {
                var exist = (product_img)_db.product_imgs.Where(t => t.product_img_id == img.product_img_id).FirstOrDefault();
                if (exist != null)
                {

                    exist.product_img_file_name = img.product_img_file_name;
                    _db.SubmitChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int Delete(ProductImgDTO img)
        {
            try
            {
                var temp = AutoMapperConfig.Mapper.Map<ProductImgDTO, product_img>(img);
                product_img exist = _db.product_imgs.Where(t => t.product_img_id == temp.product_img_id).FirstOrDefault();
                _db.product_imgs.DeleteOnSubmit(exist);
                _db.SubmitChanges();
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
