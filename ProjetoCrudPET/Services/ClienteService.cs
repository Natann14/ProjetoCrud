using ProjetoCrudPET.Models;
using ProjetoCrudPET.Repositories;

namespace ProjetoCrudPET.Services
{
    public class ClienteService : GenericService<Cliente,  ClienteRepository>
    {
        public ClienteService(ClienteRepository repositorio) : base(repositorio)
        {
        }
    }
}

/*{
      private ClienteRepository Repositorio { get; set; }
      public ClienteService(ClienteRepository repositorio) 
      {
          this.Repositorio = repositorio;
      }

      public Cliente? Get(long id) 
      {
          return this.Repositorio.Get(id);
      }

      public List<Cliente> Listar()
      {
          return this.Repositorio.Listar();
      }

      public Cliente Adicionar(Cliente cliente)
      {
          return this.Repositorio.Adicionar(cliente);
      }

      public Cliente Atualizar(Cliente cliente)
      {
          Cliente? cliente_cadastrado = this.Get((long) cliente.Id);

          if (cliente_cadastrado == null)
          {
              return null;
          }
          else
          {
              return this.Repositorio.Atualizar(cliente);
          }
      }

      public bool Excluir(long id)
      {
          return this.Repositorio.Excluir(id);
      }

  }*/

