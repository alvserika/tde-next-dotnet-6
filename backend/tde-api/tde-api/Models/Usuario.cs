using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace tde_api.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string? Cpf { get; set; }
        public string? Nome { get; set; }

        public string? Email { get; set; }
        public string? Senha { get; set; }

        [JsonIgnore]
        public List <Reserva>? Reservas { get; set; }

    }
}
