using System;
using System.Collections.Generic;
using System.Linq;

public class AlunoDisciplina
{
    public int Ano { get; set; }
    public int Semestre { get; set; }

}

public class AlunoDisciplinaCRUD
{
    private List<AlunoDisciplina> alunoDisciplinas = new List<AlunoDisciplina>();

    public void Create(AlunoDisciplina alunoDisciplina)
    {
        alunoDisciplinas.Add(alunoDisciplina);
    }

    public AlunoDisciplina Read(int ano, int semestre)
    {
        return alunoDisciplinas.FirstOrDefault(ad => ad.Ano == ano && ad.Semestre == semestre);
    }

    public void Update(int ano, int semestre, AlunoDisciplina alunoDisciplina)
    {
        var item = Read(ano, semestre);
        if (item != null)
        {
           
        }
    }

    public void Delete(int ano, int semestre)
    {
        var item = Read(ano, semestre);
        if (item != null)
        {
            alunoDisciplinas.Remove(item);
        }
    }
}

