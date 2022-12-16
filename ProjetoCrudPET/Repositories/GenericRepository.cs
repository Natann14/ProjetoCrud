using ProjetoCrudPET.Models;

namespace ProjetoCrudPET.Repositories
{
    public abstract class GenericRepository<T> where T : Entidade
    {
        protected readonly DataContext dc;

        public GenericRepository()
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json")) 
            .Build();
            dc = new DataContext(configuration);
        }

        public T? Get(long? id)
        {
            return this.dc.Set<T>().Where(a => a.Id.Equals(id)).FirstOrDefault();
        }

        public List<T> Listar()
        {
            return this.dc.Set<T>().ToList();
        }

        public T Adicionar(T entidade)
        {
            this.dc.Set<T>().Add(entidade);
            this.dc.SaveChanges();
            return entidade;                     
        }

        public T Atualizar(T entidade)
        {
            T? entidade1 = Get(entidade.Id);
            if (entidade1 == null)
            {
                throw new Exception(typeof(T).Name + " com o ID informado não foi encontrado(a)!");
            }
            else
            {
                var properties = entidade1.GetType().GetProperties();
                foreach (var prop in properties)
                {
                    prop.SetValue(entidade1, prop.GetValue(entidade));

                }
                entidade1 = this.dc.Set<T>().Update(entidade1).Entity;
                this.dc.SaveChanges();
                return entidade1;
            }
        }
        
        public bool Excluir(long id)
        {
            T? itemRemovido = this.Get(id);
            if (itemRemovido != null)
            {
                this.dc.Set<T>().Remove(itemRemovido);
                this.dc.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
