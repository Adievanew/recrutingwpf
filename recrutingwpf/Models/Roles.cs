﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recrutingwpf.Models
{
    internal class Roles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Users> Users { get; set; }
    }
}
