﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ats.Models.ViewModel
{
    public class InterPreEmpDetailViewModel
    {

        public int EmploymentId { get; set; }
        public int CandidateId { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Designation { get; set; }
        public string WorkFrom { get; set; }
        public string WorkTo { get; set; }
        public string CtcMonth { get; set; }

    }
}