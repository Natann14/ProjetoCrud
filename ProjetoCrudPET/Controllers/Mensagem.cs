namespace ProjetoCrudPET.Controllers
{
    public class Mensagem
    {
        public int Codigo { get; set; }
        public string? Texto { get; set; }

        public Mensagem(int codigo, string texto) 
        {
            Codigo = codigo;
            Texto = texto;
        }
    }

    public class MensagemErrorModel
    {
        public string? RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
