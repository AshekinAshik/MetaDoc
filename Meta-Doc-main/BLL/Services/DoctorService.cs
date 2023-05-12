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
            var cfg = new MapperConfiguration(c =>
            {
                //c.CreateMap<Doctor, DoctorDTO>();
                //c.CreateMap<Doctor, UserDTO>();

                c.CreateMap<DoctorDTO, Doctor>();
                c.CreateMap<DoctorDTO, User>();
            });
            var mapper = new Mapper(cfg);

            var data_doctor = mapper.Map<Doctor>(obj);
            var result_doctor = DataAccessFactory.DoctorData().Create(data_doctor);
            
            var data_user = mapper.Map<User>(obj);
            data_user.Role = "Doctor";
            var result_user = DataAccessFactory.UserData().Create(data_user);
            //var redata = mapper.Map<DoctorDTO>(result_doctor);
            //var redata1 = mapper.Map<UserDTO>(result_user);
            return obj;
        }

        public static bool Delete(int Id)
        {
            var doctor = DataAccessFactory.DoctorData().Get(Id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Doctor, DoctorDTO>();
                c.CreateMap<Doctor,UserDTO>();
            });
            var mapper = new Mapper(cfg);

            var result_doctor = DataAccessFactory.DoctorData().Delete(Id);
            var reult_user = DataAccessFactory.UserData().Delete(doctor.Username);

            return result_doctor;
        }

        public static DoctorDTO Update(DoctorDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Doctor, DoctorDTO>();
                c.CreateMap<DoctorDTO, Doctor>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Doctor>(obj);
            var result = DataAccessFactory.DoctorData().Update(data);
            var redata = mapper.Map<DoctorDTO>(result);
            return redata;
        }
    }
}