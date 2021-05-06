using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Request;
using eProdaja.WebAPI.Database;
using eProdaja.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly eProdajaContext _context;
        private readonly IMapper _mapper;
        public KorisniciService (eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public KorisniciModel Authenticiraj(string username, string pass)
        {
            //var user = _context.Korisnici.Include("KorisniciUloge.Uloga").FirstOrDefault(x => x.KorisnickoIme == username);
            var user = _context.Korisnici.Include(x=>x.KorisniciUloge).FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<KorisniciModel>(user);
                }
            }

            return null;
        }

        public string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

      

        public string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }

    

        public List<KorisniciModel> Get(KorisniciSearchRequest request)
        {
            var query= _context.Korisnici.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Ime))//korisnik unio parametar ime
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }
            var list = query.ToList();
            return _mapper.Map<List<KorisniciModel>>(list);
        }

        public KorisniciModel GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);

            return _mapper.Map<KorisniciModel>(entity);
        }

        public KorisniciModel Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Korisnici>(request);

            if(request.Password!=request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slažu!");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt,request.Password);
          
            _context.Korisnici.Add(entity);
          

            foreach (var uloga in request.Uloge)
            {
                _context.KorisniciUloge.Add(new Database.KorisniciUloge()
                {
                    DatumIzmjene=DateTime.Now,
                    KorisnikId=entity.KorisnikId,
                    UlogaId=uloga
                });
            }
            _context.SaveChanges();
            return _mapper.Map<KorisniciModel>(entity);
        }

        public KorisniciModel Update(int id, KorisniciInsertRequest request)
        {
            var entity = _context.Korisnici.Find(id);

            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);

            _mapper.Map(request, entity);

          /*  if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new UserException("Passwordi se ne slažu!");
                }
                //TODO: update password
            }*/

            _context.SaveChanges();

            return _mapper.Map<KorisniciModel>(entity);
        }
    }
}
