namespace AppGestaoDeResiduos.DTOs
{
    public class UsuarioEnderecoDTO
    {
        // Dados do Usuário
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public bool? AgendouColeta { get; set; }
        public bool? FoiNotificado { get; set; }

        // Dados do Endereço
        public int? Cep { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Rua { get; set; }
        public int? Numero { get; set; }
    }
}
