using FinanceApp.Core.Enums;

namespace FinanceApp.Core.Entities;

public class Membros
{
#nullable disable
    public int Id { get; set; }
    public string NomeCompleto { get; set; }
    public DateTime? DataNascimento { get; set; }
    public GrauParentescoEnum? GrauParentesco { get; set; }
}
