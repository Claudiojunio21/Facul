public class Disciplina
{
    public long DisciplinaId { get; set; }
    public string Nome { get; set; }
    public int CargaHoraria { get; set; } 
}

public class DisciplinaCRUD
{
    private List<Disciplina> disciplinas = new List<Disciplina>();

    public void Create(Disciplina disciplina)
    {
        disciplinas.Add(disciplina);
    }

    public Disciplina Read(long disciplinaId)
    {
        return disciplinas.FirstOrDefault(d => d.DisciplinaId == disciplinaId);
    }

    public void Update(long disciplinaId, Disciplina disciplina)
    {
        var item = Read(disciplinaId);
        if (item != null)
        {
            item.Nome = disciplina.Nome;
            item.CargaHoraria = disciplina.CargaHoraria; 
        }
    }

    public void Delete(long disciplinaId)
    {
        var item = Read(disciplinaId);
        if (item != null)
        {
            disciplinas.Remove(item);
        }
    }
}
