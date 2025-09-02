using FinanceApp.Core.Enums;

namespace FinanceApp.Core.InputModels;

public class MembrosInputModel
{
#nullable disable
    public string NomeCompleto { get; set; }
    public DateTime? DataNascimento { get; set; }
    public GrauParentescoEnum? GrauParentesco { get; set; }
}

