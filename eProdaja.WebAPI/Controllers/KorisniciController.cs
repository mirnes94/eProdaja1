using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.Model.Request;
using eProdaja.WebAPI.Database;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<KorisniciModel> Get([FromQuery] KorisniciSearchRequest request)
        {

            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public KorisniciModel GetById(int id)
        {

            return _service.GetById(id);
        }

        [Authorize(Roles="Administrator")]
        [HttpPost]
        public KorisniciModel Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public KorisniciModel Update(int id, [FromBody] KorisniciInsertRequest request)
        {
            return _service.Update(id,request);
        }
    }
}
