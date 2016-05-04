﻿using Entities.Interfaces;
using System.Collections.Generic;

namespace Entities
{
    public abstract class Company
    {
        public string Name { get; set; }

        public IAddress Address { get; set; }

        public List<Employment> Employments { get; set; }
    }
}