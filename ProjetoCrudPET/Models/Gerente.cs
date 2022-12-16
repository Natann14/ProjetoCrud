using ProjetoCrudPET.Models;

namespace ProjetoCrudPET.Controllers
{
    public class Gerente : Entidade
    {
        public string? Nome { get; set; }

        public string? Cpf { get; set; }
        public string? Conta { get; set; }
        public double SaldoConta { get; set; }
        public int AcoesVendidas { get; set; }

        public Gerente(long id)
        {
            Id = id;
        }

        public Gerente(long id, string nome, string cpf, string nconta, double saldoconta, int acoesvendidas)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Conta = nconta;
            SaldoConta = saldoconta;
            AcoesVendidas = acoesvendidas;
        }

        public Gerente()
        {

        }

    }
}

