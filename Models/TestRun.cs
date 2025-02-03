using System.ComponentModel.DataAnnotations;

namespace PlataformaTestes.Models
{
    public class TestRun
    {
        [Key]
        public Guid Id { get; set; }
        public Guid TestCaseId { get; set; }
        public Guid EnvironmentId { get; set; }
        public Guid? UsuarioId { get; set; }
        public string Status { get; set; }
        public DateTime DataExecucao { get; set; } = DateTime.UtcNow;
        public string Logs { get; set; }

    // Construtor padrão
    public TestRun()
    {
        Status = string.Empty;
        Logs = string.Empty;
    }
    }
}
