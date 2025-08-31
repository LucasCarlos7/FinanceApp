using System.ComponentModel;

namespace FinanceApp.Core.Enums;

public enum GrauParentescoEnum
{
    [Description("Conhecido")]
    CONHECIDO = 1,

    [Description("Filho(a)")]
    FILHO = 2,

    [Description("Cônjuge")]
    CONJUGE = 3,

    [Description("Amigo")]
    AMIGO = 4,

    [Description("Outros")]
    OUTROS = 5
}
