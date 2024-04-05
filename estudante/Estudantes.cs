

namespace WebApp.estudante
{
    public class Estudantes(string Name, bool Ativo, string Curso)
    {
        public string Name { get; private set; } = Name;
        public Guid Id { get; init; } = Guid.NewGuid();
        public bool Ativo { get; private set; } = Ativo;
        public string Curso { get; private set; } = Curso;
    }
}