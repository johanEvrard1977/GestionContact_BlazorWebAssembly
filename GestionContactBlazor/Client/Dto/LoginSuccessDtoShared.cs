﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionContact.Client.Dto
{
    public class LoginSuccessDtoShared
    {
        public int Id { get; set; }
        public string Email { get; set; }
        //public IEnumerable<string> Roles { get; set; }
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
