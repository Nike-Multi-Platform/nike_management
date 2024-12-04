using System;
using System.Collections.Generic;
using LibDTO;
using LibDAL;

namespace LibBLL
{
    public class FlashSaleManager
    {
        private readonly FlashSaleRespository _flashSaleRepository;

        public FlashSaleManager(FlashSaleRespository flashSaleRepository)
        {
            _flashSaleRepository = flashSaleRepository;
        }

        public FlashSaleManager()
        {
            _flashSaleRepository = new FlashSaleRespository(new DbContextDataContext());
        }

        public List<FlashSaleDTO> GetAll()
        {
            return _flashSaleRepository.getFlashSale();
        }
        public int Add(FlashSaleDTO entity)
        {
            return _flashSaleRepository.AddFlashSale(entity);
        }
        public int Update(FlashSaleDTO entity) {
            return _flashSaleRepository.Edit(entity);
        }

        public int Delete(FlashSaleDTO entity)
        {
            return _flashSaleRepository.Delete(entity);
        }


    }
}
