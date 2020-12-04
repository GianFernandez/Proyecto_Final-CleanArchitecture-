using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entities
{
    public class User : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}