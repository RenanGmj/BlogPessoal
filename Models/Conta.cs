using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPessoal.Models
{
    public class Conta
    {
        [Key]
        public int IdConta { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}