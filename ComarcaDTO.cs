﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC4
{
    public class ComarcaDTO
    {
        public int Year { get; set; }
        public int CodiComarca { get; set; }
        public string NomComarca { get; set; }
        public int Poblacio { get; set; }
        public int DomesticXarxa { get; set; }
        public int ActivitatsEconomiques { get; set; }
        public int Total { get; set; }
        public double ConsumDomesticPerCapita { get; set; }
    }
}
