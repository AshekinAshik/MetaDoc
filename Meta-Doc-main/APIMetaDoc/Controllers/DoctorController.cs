using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIMetaDoc.Controllers
{
    public class DoctorController : ApiController
    {
        [HttpGet]
        [Route("api/doctors")]
        public HttpResponseMessage Doctors()
        {
            try
            {
                var data = DoctorService.Get();

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/doctors/{id}")]
        public HttpResponseMessage Doctors(int Id)
        {
            try
            {
                var data = DoctorService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/doctors/create")]
        public HttpResponseMessage Create(DoctorDTO data)
        {
            try
            {
                var res = DoctorService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/doctors/update")]
        public HttpResponseMessage Update(DoctorDTO data)
        {

            var exmp = DoctorService.Get(data.Id);

            if (exmp != null)
            {
                try
                {
                    var res = DoctorService.Update(data);

                    return Request.CreateResponse(HttpStatusCode.OK, "Updated");

                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Project not found");
        }

        [HttpPost]
        [Route("api/doctors/delete")]
        public HttpResponseMessage Delete(DoctorDTO data)
        {
            var exmp = DoctorService.Get(data.Id);

            if (exmp != null)
            {
                try
                {
                    var res = DoctorService.Delete(data.Id);
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted");

                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Member not found");
        }
    }
}

