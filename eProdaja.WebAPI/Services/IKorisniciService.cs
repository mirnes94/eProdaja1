using eProdaja.Model;
using eProdaja.Model.Request;
using eProdaja.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<KorisniciModel> Get(KorisniciSearchRequest request);

        public string GenerateSalt();
        public string GenerateHash(string salt,string password);

        KorisniciModel Authenticiraj(string username, string pass);

        KorisniciModel GetById(int id);
        KorisniciModel Insert(KorisniciInsertRequest request);
        KorisniciModel Update(int id, KorisniciInsertRequest request);
    }
}
