using Microsoft.EntityFrameworkCore.Query.Internal;
using ProjetoCrudPET.Models;

namespace ProjetoCrudPET.Repositories
{
    public class ClienteRepository : GenericRepository<Cliente>
    {

    }
}
    /*{
        //private List<Cliente> CLIENTES_CADASTRADOS;

        private DataContext dc;
        public ClienteRepository() 
        {
            //CLIENTES_CADASTRADOS = new List<Cliente>();
            //CLIENTES_CADASTRADOS.Add(new Cliente(1, "João", "00000000000", "01000000", 500.5));
            //CLIENTES_CADASTRADOS.Add(new Cliente(2, "Joana", "11111111111", "02000000", 1000));
            //CLIENTES_CADASTRADOS.Add(new Cliente(3, "Maria", "22222222222", "03000000", 100.5));
            //CLIENTES_CADASTRADOS.Add(new Cliente(4, "Mário", "33333333333", "04000000", 300));
            var configuration = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json"))
                .Build();

            dc = new DataContext(configuration);
        }

        public Cliente? Get(long id)
        {
            //foreach (Cliente cliente in CLIENTES_CADASTRADOS)
             //{
               //  if (cliente.Id == id)
                // {
                     return cliente;
  //               }
         //    }
             return null;
            return this.dc.Set<Cliente>().Where(c => c.Id.Equals(id)).FirstOrDefault();
        }

        public List<Cliente> Listar()
        {
            //return CLIENTES_CADASTRADOS;
            return this.dc.Set<Cliente>().ToList();
        }

        public Cliente Adicionar(Cliente cliente)
        {
            //long id_disponivel = 0;

            //if(CLIENTES_CADASTRADOS.Count == 0)
            //{
              //  id_disponivel = 1;
            //}
            //else
            //{
            //    id_disponivel = (long)CLIENTES_CADASTRADOS[CLIENTES_CADASTRADOS.Count - 1].Id + 1;
            //}

            //cliente.Id = id_disponivel;
            //CLIENTES_CADASTRADOS.Add(cliente);
            //return cliente;

            this.dc.Set<Cliente>().Add(cliente);
            this.dc.SaveChanges();
            
            return cliente;
        }


        public Cliente Atualizar(long id, Cliente cliente)
        {
            //Cliente? cliente_cadastrado = Get(id);
            //cliente_cadastrado.Nome = cliente_novosdados.Nome;
            //cliente_cadastrado.Cpf = cliente_novosdados.Cpf;
            //cliente_cadastrado.Conta = cliente_novosdados.Conta;
            //cliente_cadastrado.SaldoConta = cliente_novosdados.SaldoConta;

            //return cliente_cadastrado;

            Cliente c = Get((long)cliente.Id);
            c.Nome = cliente.Nome;
            c.Cpf = cliente.Cpf;
            c = this.dc.Set<Cliente>().Update(c).Entity;
            this.dc.SaveChanges();
            return c;
        }

        public bool Excluir(long id)
        {
            //foreach (Cliente cliente in CLIENTES_CADASTRADOS)
            //{
                //if (cliente.Id == id)
                //{
                //    return CLIENTES_CADASTRADOS.Remove(cliente);
                //}
            //}
            //return false;
            Cliente? cliente_removido = this.Get(id);
            if (cliente_removido != null)
            {
                this.dc.Set<Cliente>().Remove(cliente_removido);
                this.dc.SaveChanges();
               
                return true;
            }
            return false;


        }

    }*/
