﻿using codeFirst.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirst.Models
{
    public class Restaurant : Entity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public List<Food> Foods { get; set; }

    }
}
