﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class InvoiceAppStatusUpdateDto:IDto
    {
        public int Id { get; set; }
        public bool AppStatus { get; set; }
    }
}
