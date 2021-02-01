using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AlunosAPI.Modelo
{
    public class Aluno
    {
        // regras do bd
        public int AlunoId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
    }
}
