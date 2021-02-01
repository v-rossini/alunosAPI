using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AlunosAPI.Modelo
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        // classe aluno (projeto) <-> tabela aluno (bd)
        public DbSet<Aluno> Alunos { get; set; }
    }
}
