using Microsoft.AspNetCore.Mvc;
using ProjetoCrudPET.Models;
using ProjetoCrudPET.Repositories;
using ProjetoCrudPET.Services;

namespace ProjetoCrudPET.Controllers
{
    [Route("api/gerentes")]
    [ApiController]
    public class GerenteController : GenericController<Gerente, GerenteRepository, GerenteService>
    {
        public GerenteController() : base()
        {
            this.servico = new GerenteService(new GerenteRepository());
        }
    }
}
