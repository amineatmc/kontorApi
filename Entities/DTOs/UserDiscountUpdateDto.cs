﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UserDiscountUpdateDto: IDto
    {
        public int Id { get; set; }
        public decimal Discount { get; set; }

    }
}
