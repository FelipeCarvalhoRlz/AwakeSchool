using AwakeSchool.Areas.WebApi.Infrastructure.Mappings;
using AwakeSchool.Areas.WebApi.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace AwakeSchool.Areas.WebApi.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("AwakeDB")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer<DataContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new AlunoMap());
        }

        public DbSet<Aluno> Alunos { get; set; }

    }
}