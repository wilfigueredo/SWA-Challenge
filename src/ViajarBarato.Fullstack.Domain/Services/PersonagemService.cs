﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViajarBarato.Fullstack.Domain.Interface;
using ViajarBarato.Fullstack.Domain.Models;


namespace ViajarBarato.Fullstack.Domain.Services
{
    public class PersonagemService : IPersonagemService
    {
        private readonly IPersonagemRepositorio _personagemRepository;

        public PersonagemService(IPersonagemRepositorio personagemRepositorio)
        {
            _personagemRepository = personagemRepositorio;
        }

        public Task<IEnumerable<KeyValuePair<Personagem, int>>> ObterPaginado(int page)
        {
            return _personagemRepository.ObterPaginado(page);
        }

        public Task<IEnumerable<Personagem>> ObterTodos()
        {
            return _personagemRepository.ObterTodos();
        }
    }
}
