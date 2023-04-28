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
    public class DoctorService
    {
        public static List<DoctorDTO> Get()
        {
            var data = DataAccessFactory.DoctorData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Doctor, DoctorDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DoctorDTO>>(data);
            return mapped;
        }

        public static DoctorDTO Get(int Id)
        {
            var data = DataAccessFactory.DoctorData().Get(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Doctor, DoctorDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DoctorDTO>(data);
            return mapped;
        }

        public static DoctorDTO Create(DoctorDTO obj) // Need To Be Sure About This
        {
            var data = DataAccessFactory.DoctorData().Create();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Doctor, DoctorDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DoctorDTO>(data);
            return mapped;
        }

        public static DoctorDTO Delete(int Id)
        {
            var data = DataAccessFactory.DoctorData().Delete(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Doctor, DoctorDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DoctorDTO>(data);
            return mapped;
        }

        public static DoctorDTO Update(DoctorDTO obj)
        {
            var data = DataAccessFactory.DoctorData().Update(obj);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Doctor, DoctorDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DoctorDTO>(data);
            return mapped;
        }
    }
}
