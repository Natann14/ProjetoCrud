using ProjetoCrudPET.Controllers;
using ProjetoCrudPET.Models;
using ProjetoCrudPET.Repositories;

namespace ProjetoCrudPET.Services
{
    public class GerenteService : GenericService<Gerente, GerenteRepository>
    {
        public GerenteService(GerenteRepository repositorio) : base(repositorio)
        {
        }
    }
}
