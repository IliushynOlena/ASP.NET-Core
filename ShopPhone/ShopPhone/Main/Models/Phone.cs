﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string name { set; get; }
        public string description { get; set; }
        public string img { set; get; }
        public uint price { set; get; }
        public virtual Category Category { set; get; }
    }
}