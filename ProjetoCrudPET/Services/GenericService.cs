using ProjetoCrudPET.Models;
using ProjetoCrudPET.Repositories;

namespace ProjetoCrudPET.Services
{
    public class GenericService<T, R> where T : Entidade where R : GenericRepository<T>
    {
        private GenericRepository<T> Repositorio { get; set; }
        public GenericService(GenericRepository<T> repositorio)
        {
            this.Repositorio = repositorio;
        }

        public T? Get(long id)
        {
            return this.Repositorio.Get(id);
        }

        public List<T> Listar()
        {
            return this.Repositorio.Listar();
        }

        public T Adicionar(T entidade)
        {
            return this.Repositorio.Adicionar(entidade);
        }

        public T Atualizar(T entidade)
        {
            T? cliente_cadastrado = this.Get((long) entidade.Id);

            if (cliente_cadastrado == null)
            {
                return null;
            }
            else
            {
                return this.Repositorio.Atualizar(entidade);
            }
        }

        public bool Excluir(long id)
        {
            return this.Repositorio.Excluir(id);
        }

    }
}
