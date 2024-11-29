namespace AppGestaoDeResiduos.Models
{
    public class UsuarioNotificacao
    {
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }



        public Notificacao Notificacao { get; set; }
        public int NotificacaoId { get; set; }
        
    }
}
