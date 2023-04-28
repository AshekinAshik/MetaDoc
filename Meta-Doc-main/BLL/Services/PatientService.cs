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
    public class PatientService
    {
        public static List<PatientDTO> Get()
        {
            var data = DataAccessFactory.PatientData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Patient, PatientDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PatientDTO>>(data);
            return mapped;
        }

        public static PatientDTO Get(int Id)
        {
            var data = DataAccessFactory.PatientData().Get(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Patient, PatientDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PatientDTO>(data);
            return mapped;
        }

        public static PatientDTO Create(PatientDTO obj) // Need To Be Sure About This
        {
            var data = DataAccessFactory.PatientData().Create(obj);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Patient, PatientDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PatientDTO>(data);
            return mapped;
        }

        public static PatientDTO Delete(int Id)
        {
            var data = DataAccessFactory.PatientData().Delete(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Patient, PatientDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PatientDTO>(data);
            return mapped;
        }

        public static PatientDTO Update(PatientDTO obj)
        {
            var data = DataAccessFactory.PatientData().Update(obj);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Patient, PatientDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PatientDTO>(data);
            return mapped;
        }
    }
}
