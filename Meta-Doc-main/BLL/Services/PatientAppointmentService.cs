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
    public class PatientAppointmentService
    {
        public static List<PatientAppoinmentDTO> Get()
        {
            var data = DataAccessFactory.PatientAppointmentData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PatientAppointment, PatientAppoinmentDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PatientAppoinmentDTO>>(data);
            return mapped;
        }

        public static PatientAppoinmentDTO Get(int Id)
        {
            var data = DataAccessFactory.PatientAppointmentData().Get(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PatientAppointment, PatientAppoinmentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PatientAppoinmentDTO>(data);
            return mapped;
        }
    }
}
