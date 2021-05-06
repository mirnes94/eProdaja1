using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Request;
using eProdaja.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Korisnici,KorisniciModel>();
            CreateMap<Korisnici, KorisniciInsertRequest>().ReverseMap();
            CreateMap<JediniceMjere, JediniceMjereModel>().ReverseMap();
            CreateMap<VrsteProizvoda, VrsteProizvodaModel>().ReverseMap();
            CreateMap<ProizvodInsertUpdateRequest, Proizvodi>();
            CreateMap<Proizvodi, Model.Proizvod>();
      
        }
    }
}
