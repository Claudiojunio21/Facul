public class Curso
{
    public long CursoId { get; set; }
    public string Nome { get; set; }
}

public class CursoCRUD
{
    private List<Curso> cursos = new List<Curso>();

    public void Create(Curso curso)
    {
        cursos.Add(curso);
    }

    public Curso Read(long cursoId)
    {
        return cursos.FirstOrDefault(c => c.CursoId == cursoId);
    }

    public void Update(long cursoId, Curso curso)
    {
        var item = Read(cursoId);
        if (item != null)
        {
            item.Nome = curso.Nome;
        }
    }

    public void Delete(long cursoId)
    {
        var item = Read(cursoId);
        if (item != null)
        {
            cursos.Remove(item);
        }
    }
}
