
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entities
{
    public class Entrega: IdentityUser
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
