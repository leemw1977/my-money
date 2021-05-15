﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Web.PersistenceModels
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Site Site { get; set; }
        public AccountType Type { get; set; }
        public Currency AccountCurrency { get; set; }
    }
}
