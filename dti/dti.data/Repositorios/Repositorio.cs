using Dapper;
using dti.data.Contextos;
using dti.domain.core.Entidades;
using dti.domain.core.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace dti.data.Repositorios
{
  public class Repositorio<TEntidade> : IRepositorio<TEntidade>
    where TEntidade : Entidade
  {
    private readonly DtiContexto _contexto;
    private readonly IDbConnection _conexao;
    private readonly DbSet<TEntidade> _tabela;

    public Repositorio(DtiContexto contexto)
    {
      _contexto = contexto;
      _conexao = contexto.Database.Connection;
      _tabela = contexto.Set<TEntidade>();
    }

    public void Atualizar(TEntidade entidade)
    {
      var e = Obter(entidade.Id);

      if (e == null)
      {
        _tabela.Add(entidade);
      }
      else
      {
        _contexto.Entry(entidade).State = EntityState.Modified;
      }

      _contexto.SaveChanges();
    }

    public void Excluir(Guid id)
    {
      var entidade = Obter(id);

      if (entidade == null) return;

      _tabela.Remove(entidade);
      _contexto.SaveChanges();
    }

    public TEntidade Obter(Guid id)
    {
      return _tabela.Find(id);
    }

    public IEnumerable<TEntidade> Obter()
    {
      return _tabela.ToList();
    }

    public void Dispose()
    {
      GC.SuppressFinalize(this);
    }
  }
}
