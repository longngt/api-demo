﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Demo.Models
{
    public class Project
    {
        [Required]
        public int? id { get; set; }
        [Required]
        public string title { get; set; }

    }
}
