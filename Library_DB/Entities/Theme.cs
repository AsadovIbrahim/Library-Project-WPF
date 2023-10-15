﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DB.Entities
{
    public class Theme : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Book>? Book { get; set; }
    }
}