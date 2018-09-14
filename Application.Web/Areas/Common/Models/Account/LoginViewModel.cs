﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Web.Areas.Common.Models.Account
{
    public class LoginViewModel
    {
        public string LoginName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
