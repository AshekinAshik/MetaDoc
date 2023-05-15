﻿using APIMetaDoc.Auth;
using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIMetaDoc.Controllers
{
    [EnableCors("*", "*", "*")]
    public class PatientController : ApiController
    {
        [Logged]
        [HttpGet]
        [Route("api/patients")]
        public HttpResponseMessage Patients()
        {
            try
            {
                var data = PatientService.Get();

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [PatientAccess]
        [Logged]
        [HttpGet]
        [Route("api/patients/{id}")]
        public HttpResponseMessage Patients(int Id)
        {
            try
            {
                var data = PatientService.Get(Id);
                if (data.Username == AuthService.Check())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else return Request.CreateResponse(HttpStatusCode.OK, "Invalid Search");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/patients/create")]
        public HttpResponseMessage Create(PatientDTO data)
        {
            try
            {
                var res = PatientService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [PatientAccess]
        [Logged]
        [HttpPost]
        [Route("api/patients/update")]
        public HttpResponseMessage Update(PatientDTO data)
        {   try
            {
                var res = PatientService.Update(data);
                return Request.CreateResponse(HttpStatusCode.OK, new {Message = "Patient Updated"});
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [Logged]
        [PatientAccess]
        [HttpPost]
        [Route("api/patients/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            var exmp = PatientService.Get(Id);

            if (exmp != null)
            {
                try
                {
                    var res = PatientService.Delete(Id);
                    return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Patient Deleted" });

                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Patient not found");
        }
    }
}
