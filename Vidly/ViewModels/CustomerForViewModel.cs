﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerForViewModel
    {
        public IEnumerable<MembershipType> MembershipType { get; set; }

        public Customer Customer { get; set; }
    }
}