﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APPWEB.Models
{
    public class Conyuge
    {
        [Key]
        public int IdConyuge { get; set; }
        public string NombreC { get; set; }
        public string ApellidoC { get; set; }
        public string SexoC { get; set; }
        public int CedulaC { get; set; }
        public int TelefonoC { get; set; }
        public int CelularC { get; set; }

    }
}
