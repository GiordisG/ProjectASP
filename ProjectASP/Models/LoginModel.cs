using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectASP.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}