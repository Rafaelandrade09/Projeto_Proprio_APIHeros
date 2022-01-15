using ApiHeros.Model;
using System.Collections.Generic;

namespace ApiHeros.Service
{
    public interface IHeroiService
    {
        public List<Heroi> FindAll();

        public Heroi GetById(int id);

        public Heroi Create(Heroi heroi);

        public Heroi Update(Heroi heroi);

        public void Delete(int id);





    }
}
