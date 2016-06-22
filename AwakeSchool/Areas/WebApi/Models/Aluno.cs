using AwakeSchool.Areas.WebApi.Infrastructure;

namespace AwakeSchool.Areas.WebApi.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string NomeAluno { get; set; }

        public void Post(Aluno aluno)
        {
            using (var context = new DataContext())
            {
                context.Alunos.Add(aluno);
                context.SaveChanges();
            }
        }
    }
}