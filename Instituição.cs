using System;
using System.Collections.Generic;
using System.Linq;

public class Instituicao
{
    public long InstituicaoId { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    
}

public class InstituicaoCRUD
{
    private List<Instituicao> instituicoes = new List<Instituicao>();

    public void Create(Instituicao instituicao)
    {
        instituicoes.Add(instituicao);
    }

    public Instituicao Read(long instituicaoId)
    {
        return instituicoes.FirstOrDefault(i => i.InstituicaoId == instituicaoId);
    }

    public void Update(long instituicaoId, Instituicao instituicao)
    {
        var item = Read(instituicaoId);
        if (item != null)
        {
            item.Nome = instituicao.Nome;
            item.Endereco = instituicao.Endereco;
            
        }
    }

    public void Delete(long instituicaoId)
    {
        var item = Read(instituicaoId);
        if (item != null)
        {
            instituicoes.Remove(item);
        }
    }
}