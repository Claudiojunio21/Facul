public class Departamento
{
    public long DepartamentoId { get; set; }
    public string Nome { get; set; }
}

public class DepartamentoCRUD
{
    private List<Departamento> departamentos = new List<Departamento>();

    public void Create(Departamento departamento)
    {
        departamentos.Add(departamento);
    }

    public Departamento Read(long departamentoId)
    {
        return departamentos.FirstOrDefault(d => d.DepartamentoId == departamentoId);
    }

    public void Update(long departamentoId, Departamento departamento)
    {
        var item = Read(departamentoId);
        if (item != null)
        {
            item.Nome = departamento.Nome;
        }
    }

    public void Delete(long departamentoId)
    {
        var item = Read(departamentoId);
        if (item != null)
        {
            departamentos.Remove(item);
        }
    }
}
