using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTechRiders.Models
{
    public class Email
    {
        public string Asunto { get; set; }
        public string Comentario { get; set; }
    }
}
