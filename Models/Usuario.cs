using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BlogPessoal.Models
{
    public class Usuario : Blog
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Conta Conta { get; set; }

    }
}