﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.ViolationReportDto
{
    public class ViolationReportGetDto
    {
        public Guid Id { get; set; }
        public string CarName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone1 { get; set; }
        public string CustomerPhone2 { get; set; }
        public DateTime ViolationDate { get; set; }
        public double Value { get; set; }
        public double Payment { get; set; }
        public double Rest { get; set; }
        public string StockName { get; set; }


        public string ViolationNumber { get; set; }
        public string ViolationState { get; set; }
        public string ViolationPlace { get; set; }
        public string Notes { get; set; }
    }
}
