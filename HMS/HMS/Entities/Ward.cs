﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    public class Ward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BedCount { get; set; }
        public double Price { get; set; }
    }
}
