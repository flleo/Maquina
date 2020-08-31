using Maquina.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Maquina.DAL
{
    public class MaquinaContext : DbContext
    {
        public DbSet<File> Files { get; set; }   
        public DbSet<User> Users { get; set; }
        public DbSet<Saludo> Saludos { get; set; }
        public DbSet<Despedida> Despedidas { get; set; }

        public DbSet<Idioma> Idiomas { get; set; }
    }

}