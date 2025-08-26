using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class PersonagemService
    {
        private static readonly List<Personagem> _repository = 
            GenericRepository<Personagem>.GetRepository();

        //public PersonagemService(GenericRepository<Personagem> repository)
        //{
        //    _repository = repository;
        //}

        //public Personagem Create(Personagem personagem)
        //{

        //}
    }
}
