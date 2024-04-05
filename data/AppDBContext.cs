using Microsoft.EntityFrameworkCore;
using WebApp.estudante;

namespace WebApp.data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Estudantes> Estudante {get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite(connectionString:"Data Source=Banco.sqlite");

        }


    }
}