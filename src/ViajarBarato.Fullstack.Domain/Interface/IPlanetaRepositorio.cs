﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViajarBarato.Fullstack.Domain.Models;

namespace ViajarBarato.Fullstack.Domain.Interface
{
    public interface IPlanetaRepositorio
    {
        Task<string> ObterHomeWorld(string homeworld);
    }
}