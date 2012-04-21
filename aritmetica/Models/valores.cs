using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace aritmetica.Models
{
    public class valores
    {
        [Required]
        public int valor1 { set; get; }
        [Required]
        public int valor2 { set; get; }
        
    }
}