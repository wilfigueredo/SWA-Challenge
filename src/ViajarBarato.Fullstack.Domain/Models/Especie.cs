﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ViajarBarato.Fullstack.Domain.Models
{
    public class Especie
    {       
        public string Nome { get; set; }
        public Planeta PlanetaNatal { get; set; }
    }
}
