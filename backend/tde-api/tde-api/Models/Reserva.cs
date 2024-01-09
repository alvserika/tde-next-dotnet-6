using System.ComponentModel.DataAnnotations.Schema;

namespace tde_api.Models
{
    [Table("Reservas")]
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }
        public Destino? Destino { get; set; }
        public int DestinoId { get; set; }
    }
}
