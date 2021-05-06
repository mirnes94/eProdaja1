using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.Model.Request;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.WebAPI.Controllers
{

    public class ProizvodController : BaseCRUDController<Model.Proizvod, ProizvodSearchRequest, ProizvodInsertUpdateRequest, ProizvodInsertUpdateRequest>
    {
        public ProizvodController(ICRUDService<Proizvod, ProizvodSearchRequest, ProizvodInsertUpdateRequest, ProizvodInsertUpdateRequest> service) : base(service)
        {
        }
    }
}
