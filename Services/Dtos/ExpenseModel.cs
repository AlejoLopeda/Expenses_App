using System;
using System.ComponentModel.DataAnnotations;

namespace Services.Dtos
{
    public class ExpenseModel
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string Category { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }  // Nombre del gasto

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El costo debe ser mayor a 0")]
        public decimal Cost { get; set; } // Costo del gasto

        [Required]
        [StringLength(100)]
        public string Power { get; set; } // Poder o detalle adicional
    }
}
