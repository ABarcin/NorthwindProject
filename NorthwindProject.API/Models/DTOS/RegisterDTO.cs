﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindProject.API.Models.DTOS
{
    public class RegisterDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}