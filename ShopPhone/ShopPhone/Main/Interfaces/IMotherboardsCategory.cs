﻿using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Interfaces
{
    public interface IMotherboardsCategory
    {
        IEnumerable<MotherboardCategory> AllMotherboardsCategories { get; }
    }
}