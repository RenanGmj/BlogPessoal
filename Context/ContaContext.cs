
using BlogPessoal.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPessoal.Context
{
    public class ContaContext : DbContext
    {
        public ContaContext(DbContextOptions<ContaContext>options) : base(options)
        {

        }

        public DbSet<Conta> Contas { get; set; }
    }
}