
namespace ProjetoCrudPET.Models
{
    public class Cliente : Entidade
    {
        public string? Nome { get; set; }

        public string? Cpf { get; set; }
        public string? Conta { get;  set; }
        public double SaldoConta { get; set; }

        public Cliente(long id)
        {
            Id = id;
        }


        public Cliente(long id, string nome, string cpf, string nconta, double saldoconta) 
        { 
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Conta = nconta;
            SaldoConta = saldoconta;
        }

        public Cliente()
        {

        }

    }
}
