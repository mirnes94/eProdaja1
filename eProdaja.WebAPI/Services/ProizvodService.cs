using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Request;
using eProdaja.WebAPI.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public class ProizvodService:BaseCRUDService<Model.Proizvod,ProizvodSearchRequest,Proizvodi, ProizvodInsertUpdateRequest, ProizvodInsertUpdateRequest>
    {
        public ProizvodService(eProdajaContext context, IMapper mapper) : base(context,mapper)
        {
        }
        public override List<Proizvod> Get(ProizvodSearchRequest search)
        {
            var query = _context.Set<Proizvodi>().AsQueryable();

            if (search?.VrstaId.HasValue == true)
            {
                query = query.Where(x => x.VrstaId == search.VrstaId);
            }

            query = query.OrderBy(x => x.Naziv);

            var list = query.ToList();

            return _mapper.Map<List<Model.Proizvod>>(list);
        }
    }
}
