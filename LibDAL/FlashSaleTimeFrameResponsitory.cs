using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using LibDTO;
using MappingLayer;

namespace LibDAL
{
    public class FlashSaleTimeFrameResponsitory
    {
        DbContextDataContext _db = new DbContextDataContext();

        public FlashSaleTimeFrameResponsitory()
        {
            _db = new DbContextDataContext();
        }

        public FlashSaleTimeFrameResponsitory(DbContextDataContext db)
        {
            _db = db;
        }

        public List<FlashSaleTimeFrameDTO> getFlashSaleTimeFrame(int flash_sale_id)
        {
            return _db.flash_sale_time_frames
                .Where(t => t.flash_sale_id == flash_sale_id)
                .OrderByDescending(t => t.createdAt)
                .Select(t => new FlashSaleTimeFrameDTO
                {
                    flash_sale_time_frame_id = t.flash_sale_time_frame_id,
                    flash_sale_id = t.flash_sale_id,
                    Start_at = t.started_at,
                    End_at = t.ended_at,
                    status = t.status,
                    CreateAt = t.createdAt,
                    UpdateAt = t.updatedAt
                })
                .ToList();
        }

        public int addFlashSaleTimeFrame(FlashSaleTimeFrameDTO flashSaleTimeFrame)
        {
            try
            {
                _db.flash_sale_time_frames.InsertOnSubmit(new flash_sale_time_frame
                {
                    flash_sale_id = flashSaleTimeFrame.flash_sale_id,
                    started_at = flashSaleTimeFrame.Start_at,
                    ended_at = flashSaleTimeFrame.End_at,
                    status = flashSaleTimeFrame.status,
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                });
                if (checkExistTimeFrame(flashSaleTimeFrame.flash_sale_id, flashSaleTimeFrame.start_at.Value, flashSaleTimeFrame.start_at.Value) == 2)
                {
                    return 2;
                }
                _db.SubmitChanges();
                return 1;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in addFlashSaleTimeFrame: {ex.Message}");
                return 0;
            }
        }

        public int Edit(FlashSaleTimeFrameDTO flashSaleTimeFrame)
        {
            try
            {
                var existingFlashSaleTimeFrame = _db.flash_sale_time_frames.FirstOrDefault(t => t.flash_sale_time_frame_id == flashSaleTimeFrame.flash_sale_time_frame_id);
                if (existingFlashSaleTimeFrame != null)
                {
                    existingFlashSaleTimeFrame.started_at = flashSaleTimeFrame.Start_at;
                    existingFlashSaleTimeFrame.ended_at = flashSaleTimeFrame.End_at;
                    existingFlashSaleTimeFrame.status = flashSaleTimeFrame.status;
                    existingFlashSaleTimeFrame.updatedAt = DateTime.Now;
                    if (checkExistTimeFrame(flashSaleTimeFrame.flash_sale_id, flashSaleTimeFrame.start_at.Value, flashSaleTimeFrame.start_at.Value) == 2)
                    {
                        return 2;
                    }
                    _db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Edit: {ex.Message}");
                return 0;
            }
        }

        public int Delete(int id)
        {
            try
            {
                var entity = _db.flash_sale_time_frames.FirstOrDefault(t => t.flash_sale_time_frame_id == id);
                if (entity != null)
                {
                    _db.flash_sale_time_frames.DeleteOnSubmit(entity);
                    _db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Delete: {ex.Message}");
                return 0;
            }
        }

        private int checkExistTimeFrame(int flashSaleId, DateTime startAt, DateTime endAt)
        {
            List<FlashSaleTimeFrameDTO> flashSaleTimeFrames = getFlashSaleTimeFrame(flashSaleId);
            foreach (FlashSaleTimeFrameDTO timeFrame in flashSaleTimeFrames)
            {
                if (startAt >= timeFrame.Start_at && startAt <= timeFrame.End_at)
                {
                    return 2; //Trùng giờ 
                }

                if (endAt >= timeFrame.Start_at && endAt <= timeFrame.End_at)
                {
                    return 2; //Trùng giờ 
                }
            }

            return 0;
        }


    }
}
