﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CentralErros.DTO
{
    public class LevelDTO
    {
        public int IdLevel { get; set; }

        [Required]
        public string LevelName { get; set; }
    }
}
