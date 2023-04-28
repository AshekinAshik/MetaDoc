using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PharmacyService
    {
        public static List<PharmacyDTO> Get()
        {
            var data = DataAccessFactory.PaymentData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Pharmacy, PharmacyDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PharmacyDTO>>(data);
            return mapped;
        }

        public static PharmacyDTO Get(int Id)
        {
            var data = DataAccessFactory.PaymentData().Get(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Pharmacy, PharmacyDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PharmacyDTO>(data);
            return mapped;
        }

        public static PharmacyDTO Create(PharmacyDTO obj) // Need To Be Sure About This
        {
            var data = DataAccessFactory.PharmacyData().Create(obj);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Pharmacy, PharmacyDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PharmacyDTO>(data);
            return mapped;
        }

        public static PharmacyDTO Delete(int Id)
        {
            var data = DataAccessFactory.PharmacyData().Delete(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Pharmacy, PharmacyDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PharmacyDTO>(data);
            return mapped;
        }

        public static PharmacyDTO Update(PharmacyDTO obj)
        {
            var data = DataAccessFactory.PharmacyData().Update(obj);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Pharmacy, PharmacyDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PharmacyDTO>(data);
            return mapped;
        }
    }
}
