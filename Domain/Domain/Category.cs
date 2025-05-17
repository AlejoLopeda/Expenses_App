using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Category // Si tienes una BaseEntity, puedes heredar de ella
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        // Activo o inactivo
        public bool IsActive { get; set; } = true;

        // Constructor sin parámetros obligatorio para EF Core
        public Category() { }

        // Constructor útil si quieres instanciar con nombre directamente
        public Category(string name)
        {
            Name = name;
            IsActive = true;
        }
    }
}
