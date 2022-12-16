using Microsoft.AspNetCore.Mvc;
using ProjetoCrudPET.Models;
using ProjetoCrudPET.Repositories;
using ProjetoCrudPET.Services;

namespace ProjetoCrudPET.Controllers
{
    public abstract class GenericController<T, R, S> : ControllerBase where T : Entidade
        where S : GenericService<T, R> where R : GenericRepository<T>
    {
        protected S? servico { get; set; }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            T? entidade = servico.Get(id);


            if (entidade == null)
            {
                return this.Ok(new Mensagem(300, $"{typeof(T).Name} não encontrado"));
            }
            else
            {
                return Ok(entidade);
            }
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return this.Ok(servico.Listar());
        }

        [HttpPost]
        public IActionResult Adicionar(T entidade)
        {
            entidade.Id = null;
            return this.Ok(servico.Adicionar(entidade));
        }

        [HttpPut]
        public IActionResult Atualizar(T entidade)
        {
            if (entidade == null || entidade.Id == null)
            {
                return this.Ok(new Mensagem(200, "É obrigatório que o ID seja colocado"));
            }
            else
            {
                T ent = servico.Atualizar(entidade);

                if (ent == null)
                {
                    return this.Ok(new Mensagem(403, "ID informado não foi encontrado(a)!"));
                }
                else
                {
                    return this.Ok(ent);
                }
            }

        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(long id)
        {
            if (servico.Excluir(id))
            {
                return this.Ok(new Mensagem(400, $"{typeof(T).Name} Excluido com sucesso!"));
            }
            else
            {
                return this.Ok(new Mensagem(301, $"{typeof(T).Name} não encontrado ou já removido!"));
            }
        }

    }

}
