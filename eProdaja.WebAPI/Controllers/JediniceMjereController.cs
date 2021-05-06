using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.WebAPI.Controllers
{
  
    public class JediniceMjereController : BaseController<JediniceMjereModel,object>
    {
        public JediniceMjereController(IService<JediniceMjereModel,object> service) : base(service) { }
       
    }
}
