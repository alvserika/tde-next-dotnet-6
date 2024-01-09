using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace tde_api.Models
{
    [Table("Destinos")]
    public class Destino
    {
        [Key]
        public int Id { get; set; }
       public string? Nome { get; set; }

        [JsonIgnore]
        public List<Reserva>? Reservas { get; set; }


    }
}
