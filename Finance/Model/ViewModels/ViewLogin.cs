﻿using Finance.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Models.ViewModels
{
    public class ViewLogin
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
    public class ViewWebLogin
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
    public class ViewToken
    {
        public string Token { get; set; }
        public UserModel Users { get; set; }
    }
}
