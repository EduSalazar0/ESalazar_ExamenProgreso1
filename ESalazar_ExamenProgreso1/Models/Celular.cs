using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ESalazar_ExamenProgreso1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Modelo { get; set; }
        [NotNull]
        public int Anio { get; set; }
        [Range(100.00, 999.00,
            ErrorMessage = "El precio debe ir 0.01 and 100.00")]
        public double Precio { get; set; }

    }
}

