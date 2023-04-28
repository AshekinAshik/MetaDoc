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
    public class PharmacyController : ApiController
    {
        [HttpGet]
        [Route("api/pharmacies")]
        public HttpResponseMessage Pharmacies()
        {
            try
            {
                var data = PharmacyService.Get();

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/pharmacies/{id}")]
        public HttpResponseMessage Pharmacies(int Id)
        {
            try
            {
                var data = PharmacyService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/pharmacies/create")]
        public HttpResponseMessage Create(PharmacyDTO data)
        {
            try
            {
                var res = PharmacyService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/pharmacies/update")]
        public HttpResponseMessage Update(PharmacyDTO data)
        {

            var exmp = PharmacyService.Get(data.Id);

            if (exmp != null)
            {
                try
                {
                    var res = PharmacyService.Update(data);

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
        [Route("api/pharmacies/delete")]
        public HttpResponseMessage Delete(PharmacyDTO data)
        {
            var exmp = PharmacyService.Get(data.Id);

            if (exmp != null)
            {
                try
                {
                    var res = PharmacyService.Delete(data.Id);
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
}
