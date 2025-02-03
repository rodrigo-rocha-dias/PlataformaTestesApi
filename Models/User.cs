using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaTestes.Models
{
    [Table("usuarios")]  // 🔥 Define o nome correto da tabela no banco
    public class User
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("nome")]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Column("senha")]
        public string Senha { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        [Column("tipo_usuario")]
        public string TipoUsuario { get; set; } = string.Empty;

        [Column("data_criacao")]
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    }
}
