using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoCrudPET.Services;
using ProjetoCrudPET.Models;
using ProjetoCrudPET.Repositories;

//GET (Ler), PUT (Incluir/Adicionar), POST (Editar), DELETE (Excluir)

namespace ProjetoCrudPET.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : GenericController<Cliente, ClienteRepository, ClienteService>
    {
        public ClienteController() : base()
        {
            this.servico = new ClienteService(new ClienteRepository());
        }
    }
}
        /*private static ClienteService servico = new ClienteService(new Repositories.ClienteRepository());

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Cliente? cliente = servico.Get(id);


            if (cliente == null)
            {
                return this.Ok(new Mensagem(300, "Cliente não encontrado"));
            }
            else
            {
                return Ok(servico.Get(id));
            }
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return this.Ok(servico.Listar());
        }

        [HttpPost]
        public IActionResult Adicionar(Cliente cliente)
        {
            cliente.Id = null;
            return this.Ok(servico.Adicionar(cliente));
        }

        [HttpPut]
        public IActionResult Atualizar(Cliente cliente)
        {
            Cliente c = servico.Atualizar(cliente);

            if(c == null)
            {
                return this.Ok(new Mensagem(200, "É obrigatório que o ID seja colocado"));
            }
            else
            {
                return this.Ok(c);
            }

        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(long id)
        {
            if (servico.Excluir(id))
            {
                return this.Ok(new Mensagem(400, "Cliente Excluido com sucesso!"));
            }
            else
            {
                return this.Ok(new Mensagem(301, "Cliente não encontrado ou já removido!"));
            }
        }

    }*/
   
