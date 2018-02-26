using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ninject.WebApi.Models
{
    public class LoginStatus
    {
        public bool IsSuccess { get; set; }
        public string AuthToken { get; set; }
    }
}