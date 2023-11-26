using System;
using System.Collections.Generic;
using System.Linq;

public class Aluno
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Municipio { get; set; }
    public string Uf { get; set; }
    public string Cep { get; set; }

  

    
    public Aluno(long id, string nome, string email, string telefone, string endereco)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Endereco = endereco;
        Complemento = complemento;
        Bairro = bairro;
        Municipio = municipio;
        Uf = uf 
        Cep = cep
        
    }
}

public class AlunoCRUD
{
    private List<Aluno> alunos = new List<Aluno>();

    // Método para criar um novo aluno
    public void Create(Aluno aluno)
    {
        alunos.Add(aluno);
    }

    // Método para ler (buscar) alunos
    public Aluno Read(long id)
    {
        return alunos.FirstOrDefault(a => a.Id == id);
    }

    // Método para atualizar um aluno existente
    public void Update(long id, Aluno aluno)
    {
        Aluno alunoParaAtualizar = alunos.FirstOrDefault(a => a.Id == id);
        if (alunoParaAtualizar != null)
        {
            alunoParaAtualizar.Nome = aluno.Nome;
            alunoParaAtualizar.Email = aluno.Email;
            alunoParaAtualizar.Telefone = aluno.Telefone;
            alunoParaAtualizar.Endereco = aluno.Endereco;
            alunoParaAtualizar.Complemento = aluno.Complemento;
            alunoParaAtualizar.Bairro = aluno.Bairro;   
            alunoParaAtualizar.Municipio = aluno.Municipio;
            alunoParaAtualizar.Uf = aluno.Uf;
            alunoParaAtualizar.Cep = aluno.Cep;

        }
    }

    // Método para deletar um aluno
    public void Delete(long id)
    {
        Aluno alunoParaDeletar = alunos.FirstOrDefault(a => a.Id == id);
        if (alunoParaDeletar != null)
        {
            alunos.Remove(alunoParaDeletar);
        }
    }
}