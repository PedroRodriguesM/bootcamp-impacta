using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDapper.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rg { get; set; }
    }
}
