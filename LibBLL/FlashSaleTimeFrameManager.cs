using System;
using System.Collections.Generic;
using LibDTO;
using LibDAL;

namespace LibBLL
{
    public class FlashSaleTimeFrameManager
    {
        private readonly FlashSaleTimeFrameResponsitory _flashSaleTimeFrameRepository;
        public FlashSaleTimeFrameManager(FlashSaleTimeFrameResponsitory flashSaleTimeFrameRepository)
        {
            _flashSaleTimeFrameRepository = flashSaleTimeFrameRepository;
        }
        public FlashSaleTimeFrameManager()
        {
            _flashSaleTimeFrameRepository = new FlashSaleTimeFrameResponsitory(new DbContextDataContext());
        }

        public List<FlashSaleTimeFrameDTO> GetAll(int flash_sale_id)
        {
            return _flashSaleTimeFrameRepository.getFlashSaleTimeFrame(flash_sale_id);
        }

        public int Add(FlashSaleTimeFrameDTO entity)
        {
            return _flashSaleTimeFrameRepository.addFlashSaleTimeFrame(entity);
        }

        public int Update(FlashSaleTimeFrameDTO entity)
        {
            return _flashSaleTimeFrameRepository.Edit(entity);
        }

        public int Delete(int id)
        {
            return _flashSaleTimeFrameRepository.Delete(id);
        }

    }
}
