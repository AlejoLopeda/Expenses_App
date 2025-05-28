using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Services.Dtos
{
    public class CategoryModel
    {
        [Required(ErrorMessage = "El nombre de la categoria es obligatorio.")]
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
    }
}