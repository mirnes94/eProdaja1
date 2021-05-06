using eProdaja.Model;
using eProdaja.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public interface IProizvodService
    {
        //IList<Proizvod> Get();
        Model.Proizvod Insert(ProizvodInsertUpdateRequest request);
    }
}
