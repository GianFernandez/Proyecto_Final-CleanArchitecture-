using System;
using System.ComponentModel.DataAnnotations;

namespace App.Core.Entities
{
    public class BaseEntidad
    {
        [Key]
        public int NumProveedor { get; set; }
        public bool Estado { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}