using System.Data.Entity.ModelConfiguration;

namespace AwakeSchool.Areas.WebApi.Infrastructure.Mappings
{
    public class AlunoMap : EntityTypeConfiguration<Models.Aluno>
    {
        public AlunoMap()
        {
            HasKey(t => t.AlunoId);

            Property(t => t.AlunoId).HasColumnName("");
            Property(t => t.NomeAluno).HasColumnName("");

            ToTable("");
        }
    }
}