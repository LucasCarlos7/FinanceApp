using FinanceApp.Core.InputModels;

namespace FinanceApp.Core.Interfaces.Services;
public interface IMembrosService
{
    Task InserirAsync(MembrosInputModel membros);
}
