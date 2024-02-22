using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPessoal.Models
{
    public class Blog 
    {
        public string Titulo { get; set; }
        public string PostText { get; set; }
        public byte[] PostDeImg { get; set; }
        public DateTime DataDepostagem { get; set; }
    }
}