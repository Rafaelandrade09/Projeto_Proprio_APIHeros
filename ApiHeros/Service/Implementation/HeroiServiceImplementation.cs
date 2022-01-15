using ApiHeros.Data;
using ApiHeros.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiHeros.Service.Implementation
{
    public class HeroiServiceImplementation : IHeroiService
    {
        private HeroiContext _context;

        public HeroiServiceImplementation(HeroiContext context)
        {
            _context = context;
        }

        public List<Heroi> FindAll()
        {
           return _context.Herois.ToList();
            
        }

        public Heroi GetById(int id)
        {
            return _context.Herois.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Heroi Create(Heroi heroi)
        {
            try
            {
                _context.Herois.Add(heroi);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return heroi;
        }


        public Heroi Update(Heroi heroi)
        {
            if (!Exist(heroi.Id)) return new Heroi();

            var resultVerification = _context.Herois.SingleOrDefault(p => p.Id.Equals(heroi.Id));

            if (resultVerification != null)
            {
                try
                {
                    _context.Entry(resultVerification).CurrentValues.SetValues(heroi);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return heroi;
        }

        

        public void Delete(int id)
        {

            var resultVerification = _context.Herois.SingleOrDefault(p => p.Id.Equals(id));

            if(resultVerification != null)
            {
                try
                {
                    _context.Herois.Remove(resultVerification);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }


        }

        private bool Exist(int id)
        {
            return _context.Herois.Any(p => p.Id.Equals(id));
        }


    }
}
